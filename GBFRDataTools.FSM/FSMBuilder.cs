﻿using RelinkFSMToolkit;

using GBFRDataTools.FSM.Converters;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM;

// TODO: Support layers & other weird branches
public class FSMSerializer
{
    public FSMNode _root;

    private List<BehaviorTreeComponent> _components = [];

    public FSMSerializer(FSMNode rootNode)
    {
        _root = rootNode;
    }

    public void WriteJson(Stream stream)
    {
        var options = new JsonWriterOptions
        {
            Indented = true
        };

        var jsonSerializerOptions = new JsonSerializerOptions()
        {
            UnmappedMemberHandling = System.Text.Json.Serialization.JsonUnmappedMemberHandling.Disallow,
        };
        jsonSerializerOptions.Converters.Add(new ElementArrayConverter());
        jsonSerializerOptions.Converters.Add(new ControllerConverter());
        jsonSerializerOptions.Converters.Add(new cVec2Converter());
        jsonSerializerOptions.Converters.Add(new cVec4Converter());

        using var writer = new Utf8JsonWriter(stream, options);
        writer.WriteStartObject();

        writer.WriteNumber("layerNo", 0);
        WriteNode(writer, _root);

        writer.WriteStartObject("addAllTransition"); writer.WriteEndObject();
        writer.WriteStartObject("addTransition"); writer.WriteEndObject();
        writer.WriteStartObject("EnableBaseTransition"); writer.WriteEndObject();
        writer.WriteStartObject("EnableBaseAllTransition"); writer.WriteEndObject();

        foreach (var component in _components)
        {
            writer.WritePropertyName(component.ComponentName);
            JsonSerializer.Serialize(writer, component, FSMParser.ComponentNameToType[component.ComponentName], jsonSerializerOptions);
        }
        writer.WriteEndObject();
        writer.Flush();
    }

    private void WriteNode(Utf8JsonWriter writer, FSMNode node)
    {
        writer.WriteStartObject("FSMNode");
        {
            writer.WriteNumber("guid_", node.Guid);
            writer.WriteNumber("tailIndexOfChildNodeGuids_", node.TailIndexOfChildNodeGuids);
            writer.WriteNumber("tailIndexOfComponentGuids_", 0);
            writer.WriteNumber("childLayerId_", -1);
            writer.WriteNumber("nameHash_", uint.MaxValue);
            writer.WriteBoolean("isBranch_", false);
            writer.WriteString("fsmName_", string.Empty);
            writer.WriteString("fsmFolderName_", string.Empty);
            writer.WriteNumber("referenceguid_", 0);
        }
        writer.WriteEndObject();

        foreach (BehaviorTreeComponent component in node.ExecutionComponents)
            _components.Add(component);

        foreach (Transition transition in node.BranchTransitions)
        {
            writer.WritePropertyName("Transition");
            writer.WriteStartObject();
            {
                writer.WriteNumber("conditionGuid_", 0);
                writer.WriteStartArray("conditionGuids_");
                {
                    foreach (BehaviorTreeComponent comp in transition.ConditionComponents)
                    {
                        writer.WriteStartObject();
                        writer.WriteNumber("Element", comp.Guid);
                        writer.WriteEndObject();

                        _components.Add(comp);
                    }
                }
                writer.WriteEndArray();

                writer.WriteNumber("toNodeGuid_", transition.ToNodeGuid);
                writer.WriteNumber("fromNodeGuid_", transition.FromNodeGuid);
                writer.WriteBoolean("isEndTransition_", false);
                writer.WriteBoolean("isFailedTransition_", false);
            }
            writer.WriteEndObject();
        }

        foreach (var child in node.Children)
            WriteNode(writer, child);
    }
}
