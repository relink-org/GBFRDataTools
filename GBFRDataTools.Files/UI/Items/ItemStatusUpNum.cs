﻿using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemStatusUpNum
public class ItemStatusUpNum // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new(0x41CEB10C, FieldType.ObjectRef),
        new(0x663ED344, FieldType.ObjectRef),
        new(0x6D6E886C, FieldType.ObjectRef),
        new(0x88FD674D, FieldType.ObjectRef),
        new(0xB17FB6A5, FieldType.ObjectRef),
        new(0xD5D0034C, FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
