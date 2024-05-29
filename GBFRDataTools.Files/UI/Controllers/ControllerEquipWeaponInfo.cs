﻿using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerEquipWeaponInfo
public class ControllerEquipWeaponInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Weapon", FieldType.ObjectRef),
        new("Soldout", FieldType.ObjectRef),
        new("SoldoutCanvas", FieldType.ObjectRef),
        new("AwakeWeaponInfo", FieldType.ObjectRef),
        new("ArrowAnims", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
