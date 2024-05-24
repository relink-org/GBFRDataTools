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

public class CheckPartyCharacter : QuestConditionComponent
{
    [JsonPropertyName("objId_")]
    public int ObjId { get; set; }

    [JsonPropertyName("keyHash_")]
    public uint KeyHash { get; set; }

    [JsonPropertyName("keyString_")]
    public string KeyString { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
