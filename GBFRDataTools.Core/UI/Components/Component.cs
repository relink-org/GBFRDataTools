﻿using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

public static class Component
{
    public static List<UIPropertyTypeDef> Properties = [
        new UIPropertyTypeDef("Enable", FieldType.Bool),
    ];
}
