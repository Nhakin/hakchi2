﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.clusterrr.hakchi_gui
{
    public interface INesMenuElement
    {
        string Code { get; }
        string Name { get; set; }
    }
}
