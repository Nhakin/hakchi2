﻿using com.clusterrr.hakchi_gui.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace com.clusterrr.hakchi_gui
{
    public class NesMenuCollection : List<INesMenuElement>
    {
        const int FoldersEqualLetters = 3;
        const int PagesEqualLetters = 3;
        public enum SplitStyle
        {
            NoSplit = 0,
            Auto = 1,
            PagesEqual = 2,
            FoldersEqual = 3,
            FoldersAlphabetic_PagesEqual = 4,
            FoldersAlphabetic_FoldersEqual = 5,
            Custom = 6
        }

        public void Split(SplitStyle style, bool originalToRoot, int maxElements)
        {
            if (style == SplitStyle.NoSplit && !originalToRoot) return;
            if (((style == SplitStyle.Auto && !originalToRoot) || style == SplitStyle.FoldersEqual || style == SplitStyle.PagesEqual) &&
                (Count <= maxElements)) return;
            var total = Count;
            var partsCount = (int)Math.Ceiling((float)total / (float)maxElements);
            var perPart = (int)Math.Ceiling((float)total / (float)partsCount);
            var alphaNum = new Regex("[^a-zA-Z0-9]");

            NesMenuCollection root;
            if (!originalToRoot)
                root = this;
            else
            {
                root = new NesMenuCollection();
                root.AddRange(this.Where(o => !(o is NesDefaultGame)));
                this.RemoveAll(o => !(o is NesDefaultGame));
                this.Add(new NesMenuFolder() { Name = Resources.FolderNameMoreGames, Position = NesMenuFolder.Priority.Last, Child = root });
            }

            var sorted = root.OrderBy(o => o.Name);
            var collections = new List<NesMenuCollection>();
            int i = 0;
            if (style == SplitStyle.Auto || style == SplitStyle.FoldersEqual || style == SplitStyle.PagesEqual)
            {
                var collection = new NesMenuCollection();
                foreach (var game in sorted)
                {
                    collection.Add(game);
                    i++;
                    if (((i % perPart) == 0) || (i == sorted.Count()))
                    {
                        collections.Add(collection);
                        collection = new NesMenuCollection();
                    }
                }
            }

            if (style == SplitStyle.Auto)
            {
                if (collections.Count >= 12)
                    style = SplitStyle.FoldersEqual;
                else
                    style = SplitStyle.PagesEqual;
            }

            // Folders, equal
            if (style == SplitStyle.FoldersEqual) // minimum amount of games/folders on screen without glitches
            {
                root.Clear();
                foreach (var coll in collections)
                {
                    var fname = alphaNum.Replace(coll.Where(o => (o is NesGame) || (o is NesDefaultGame)).First().Name.ToUpper(), "");
                    var lname = alphaNum.Replace(coll.Where(o => (o is NesGame) || (o is NesDefaultGame)).Last().Name.ToUpper(), "");

                    var folder = new NesMenuFolder() { Child = coll, NameParts = new string[] { fname, lname }, Position = NesMenuFolder.Priority.Left };
                    coll.Add(new NesMenuFolder() { Name = Resources.FolderNameBack, Image = Resources.back, Position = NesMenuFolder.Priority.Last, Child = root });
                    root.Add(folder);
                }
                TrimFolderNames(root);
            }
            else if (style == SplitStyle.PagesEqual)
            // Pages, equal
            {
                for (i = 0; i < collections.Count; i++)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        var fname = alphaNum.Replace(collections[j].Where(o => (o is NesGame) || (o is NesDefaultGame)).First().Name.ToUpper(), "");
                        var lname = alphaNum.Replace(collections[j].Where(o => (o is NesGame) || (o is NesDefaultGame)).Last().Name.ToUpper(), "");
                        var folder = new NesMenuFolder()
                        {
                            Child = j > 0 ? collections[j] : root,
                            NameParts = new string[] { fname, lname },
                            Position = NesMenuFolder.Priority.Left
                        };
                        collections[i].Insert(0, folder);
                    }
                    for (int j = i + 1; j < collections.Count; j++)
                    {
                        var fname = alphaNum.Replace(collections[j].Where(o => (o is NesGame) || (o is NesDefaultGame)).First().Name.ToUpper(), "");
                        var lname = alphaNum.Replace(collections[j].Where(o => (o is NesGame) || (o is NesDefaultGame)).Last().Name.ToUpper(), "");
                        var folder = new NesMenuFolder()
                        {
                            Child = j > 0 ? collections[j] : root,
                            NameParts = new string[] { fname, lname },
                            Position = NesMenuFolder.Priority.Right
                        };
                        collections[i].Insert(collections[i].Count, folder);
                    }
                    TrimFolderNames(collections[i]);
                }
                root.Clear();
                root.AddRange(collections[0]);
            }
            else if (style == SplitStyle.FoldersAlphabetic_PagesEqual || style == SplitStyle.FoldersAlphabetic_FoldersEqual)
            {
                var letters = new Dictionary<char, NesMenuCollection>();
                for (char ch = 'A'; ch <= 'Z'; ch++)
                    letters[ch] = new NesMenuCollection();
                letters['#'] = new NesMenuCollection();
                foreach (var game in root)
                {
                    if (!(game is NesGame || game is NesDefaultGame)) continue;
                    var letter = game.Name.Substring(0, 1).ToUpper()[0];
                    if (letter < 'A' || letter > 'Z')
                        letter = '#';
                    letters[letter].Add(game);
                }

                root.Clear();
                foreach (var letter in letters.Keys)
                    if (letters[letter].Count > 0)
                    {
                        var folder = new NesMenuFolder() { Child = letters[letter], Name = letter.ToString(), Position = NesMenuFolder.Priority.Left };
                        if (style == SplitStyle.FoldersAlphabetic_PagesEqual)
                        {
                            folder.Child.Split(SplitStyle.PagesEqual, false, maxElements);
                            folder.Child.Add(new NesMenuFolder() { Name = Resources.FolderNameBack, Image = Resources.back, Position = NesMenuFolder.Priority.Last, Child = root });
                            foreach (NesMenuFolder f in folder.Child.Where(o => o is NesMenuFolder))
                                if (f.Child != root)
                                    f.Child.Add(new NesMenuFolder() { Name = Resources.FolderNameBack, Image = Resources.back, Position = NesMenuFolder.Priority.Last, Child = root });
                        }
                        else if (style == SplitStyle.FoldersAlphabetic_FoldersEqual)
                        {
                            folder.Child.Split(SplitStyle.FoldersEqual, false, maxElements);
                            folder.Child.Add(new NesMenuFolder() { Name = Resources.FolderNameBack, Image = Resources.back, Position = NesMenuFolder.Priority.Last, Child = root });
                        }
                        //folder.Initial = letters[letter].Where(o => (o is NesGame) || (o is NesDefaultGame)).First().Code;
                        root.Add(folder);
                    }
            }
            if (originalToRoot)
            {
                if (style != SplitStyle.PagesEqual)
                    root.Add(new NesMenuFolder() { Name = Resources.FolderNameOriginalGames, Image = Resources.back, Position = NesMenuFolder.Priority.Last, Child = this });
                else
                {
                    foreach (var collection in collections)
                        collection.Add(new NesMenuFolder() { Name = Resources.FolderNameOriginalGames, Image = Resources.back, Position = NesMenuFolder.Priority.Last, Child = this });
                }
            }
        }

        void TrimFolderNames(NesMenuCollection nesMenuCollection)
        {
            const int minChars = 3;
            const int maxChars = 8;
            var folders = nesMenuCollection.Where(o => o is NesMenuFolder).OrderBy(o => o.Name).ToArray();
            for (int i = 1; i < folders.Length; i++)
            {
                var prevFolder = i > 0 ? (folders[i - 1] as NesMenuFolder) : null;
                var currentFolder = folders[i] as NesMenuFolder;
                var nameA = prevFolder.NameParts[1];
                var nameB = currentFolder.NameParts[0];
                int l = Math.Min(maxChars - 1, Math.Max(nameA.Length, nameB.Length));
                while ((nameA.Substring(0, Math.Min(l, nameA.Length)) !=
                    nameB.Substring(0, Math.Min(l, nameB.Length))) && l >= minChars)
                    l--;
                nameA = nameA.Substring(0, Math.Min(l + 1, nameA.Length));
                nameB = nameB.Substring(0, Math.Min(l + 1, nameB.Length));
                if (nameA == nameB) // There is no point to make long name
                    nameA = nameB = nameA.Substring(0, Math.Min(minChars, nameA.Length));
                prevFolder.NameParts = new string[] { prevFolder.NameParts[0], nameA };
                currentFolder.NameParts = new string[] { nameB, currentFolder.NameParts[1] };
            }
            if (folders.Length > 0)
            {
                var firstFolder = folders[0] as NesMenuFolder;
                firstFolder.NameParts = new string[] { firstFolder.NameParts[0].Substring(0, Math.Min(firstFolder.NameParts[0].Length, minChars)), firstFolder.NameParts[1] };

                var lastFolder = folders[folders.Length - 1] as NesMenuFolder;
                lastFolder.NameParts = new string[] { lastFolder.NameParts[0], lastFolder.NameParts[1].Substring(0, Math.Min(lastFolder.NameParts[1].Length, minChars)), };
            }
        }
    }
}
