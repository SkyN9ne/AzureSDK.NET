// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstanceStartStopScheduleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(TimeZoneId))
            {
                writer.WritePropertyName("timeZoneId"u8);
                writer.WriteStringValue(TimeZoneId);
            }
            if (Optional.IsCollectionDefined(ScheduleList))
            {
                writer.WritePropertyName("scheduleList"u8);
                writer.WriteStartArray();
                foreach (var item in ScheduleList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedInstanceStartStopScheduleData DeserializeManagedInstanceStartStopScheduleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<string> timeZoneId = default;
            Optional<IList<SqlScheduleItem>> scheduleList = default;
            Optional<string> nextRunAction = default;
            Optional<string> nextExecutionTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeZoneId"u8))
                        {
                            timeZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scheduleList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SqlScheduleItem> array = new List<SqlScheduleItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SqlScheduleItem.DeserializeSqlScheduleItem(item));
                            }
                            scheduleList = array;
                            continue;
                        }
                        if (property0.NameEquals("nextRunAction"u8))
                        {
                            nextRunAction = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nextExecutionTime"u8))
                        {
                            nextExecutionTime = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedInstanceStartStopScheduleData(id, name, type, systemData.Value, description.Value, timeZoneId.Value, Optional.ToList(scheduleList), nextRunAction.Value, nextExecutionTime.Value);
        }
    }
}
