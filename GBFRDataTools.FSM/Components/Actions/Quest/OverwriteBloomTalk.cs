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

public class OverwriteBloomTalk : QuestActionComponent
{
    [JsonPropertyName("npcUniqueIdList_")]
    public /*cy::PlacementInfo::Values*/ ElementArray<ulong> NpcUniqueIdList { get; set; }

    [JsonPropertyName("talkId_")]
    public string TalkId { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
