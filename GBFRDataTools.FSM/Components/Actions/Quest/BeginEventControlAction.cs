﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class BeginEventControlAction : QuestActionComponent
{
    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
