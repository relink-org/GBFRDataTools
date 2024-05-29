﻿using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::MenuDial
public class MenuDial // : Menu
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Arrow", FieldType.ObjectRef),
        new("ArrowRawImages", FieldType.ObjectRefVector),
        new("ArrowMaterials", FieldType.ObjectRefVector),
        new("ColorMode", FieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Menu.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
