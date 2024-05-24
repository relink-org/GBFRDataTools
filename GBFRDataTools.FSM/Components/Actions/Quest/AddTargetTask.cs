﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class AddTargetTask : QuestActionComponent
{
    [JsonPropertyName("label_")]
    public string Label { get; set; }

    [JsonPropertyName("isAllInMode_")]
    public bool IsAllInMode { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}({Label}, isAllInMode: {IsAllInMode})";
        return str;
    }
}
