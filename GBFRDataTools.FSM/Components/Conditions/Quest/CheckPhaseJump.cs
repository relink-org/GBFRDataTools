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

public class CheckPhaseJump : QuestConditionComponent
{
    [JsonPropertyName("isPhaseIn_")]
    public bool IsPhaseIn { get; set; }

    [JsonPropertyName("phaseNo_")]
    public int PhaseNo { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}:\n";

        return str;
    }
}
