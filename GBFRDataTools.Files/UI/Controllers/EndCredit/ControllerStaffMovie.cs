﻿using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.EndCredit;

// ui::component::ControllerStaffMovie
public class ControllerStaffMovie // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Movie", FieldType.ObjectRef),
        new("MovieImage", FieldType.ObjectRef),
        new("Skip", FieldType.ObjectRef),
        new("ShowGuide", FieldType.ObjectRef),
        new("GranMovie", FieldType.String),
        new("DjeetaMovie", FieldType.String),
        new("CommonMovie", FieldType.String),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
