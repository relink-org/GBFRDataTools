﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections;
using GBFRDataTools.FSM.Entities;
using System.Globalization;
using System.IO;

namespace GBFRDataTools.FSM.Converters;

public class cVec4Converter : JsonConverter<cVec4>
{
    public override cVec4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        int idx = 0;
        cVec4 vec = new cVec4();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
            {
                if (idx != 4)
                    throw new JsonException();

                break;
            }

            if (reader.TokenType != JsonTokenType.Number)
                throw new JsonException();

            if (idx == 0)
                vec.X = reader.GetSingle();
            else if (idx == 1)
                vec.Y = reader.GetSingle();
            else if (idx == 2)
                vec.Z = reader.GetSingle();
            else if (idx == 3)
                vec.W = reader.GetSingle();
            idx++;
        }

        return vec;
    }

    public override void Write(Utf8JsonWriter writer, cVec4 value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
