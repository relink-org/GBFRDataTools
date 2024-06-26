﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckQuestParameter : QuestConditionComponent
{
    [JsonPropertyName("keyHash_")]
    public uint KeyHash { get; set; }

    [JsonPropertyName("keyString_")]
    public string KeyString { get; set; }

    [JsonPropertyName("checkValue_")]
    public int CheckValue { get; set; }

    [JsonPropertyName("type_")]
    public int Type { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}:\n";
        //str += $"- KeyHash: {KeyHash}\n";
        str += $"- KeyString: {KeyString}\n";
        str += $"- CheckValue: {CheckValue}\n";
        str += $"- Type: {Type}";

        return str;
    }
}
