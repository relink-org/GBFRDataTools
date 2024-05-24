﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions;

public class NavMeshSwitchAction : ActionComponent
{
    [JsonPropertyName("roomName_")]
    public string RoomName { get; set; }

    [JsonPropertyName("index_")]
    public int Index { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
