// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class IotSecuritySolutionPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(UserDefinedResources))
            {
                writer.WritePropertyName("userDefinedResources"u8);
                writer.WriteObjectValue(UserDefinedResources);
            }
            if (Optional.IsCollectionDefined(RecommendationsConfiguration))
            {
                writer.WritePropertyName("recommendationsConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in RecommendationsConfiguration)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IotSecuritySolutionPatch DeserializeIotSecuritySolutionPatch(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<UserDefinedResourcesProperties> userDefinedResources = default;
            Optional<IList<RecommendationConfigurationProperties>> recommendationsConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("userDefinedResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            userDefinedResources = UserDefinedResourcesProperties.DeserializeUserDefinedResourcesProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("recommendationsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RecommendationConfigurationProperties> array = new List<RecommendationConfigurationProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendationConfigurationProperties.DeserializeRecommendationConfigurationProperties(item));
                            }
                            recommendationsConfiguration = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IotSecuritySolutionPatch(Optional.ToDictionary(tags), userDefinedResources.Value, Optional.ToList(recommendationsConfiguration));
        }
    }
}
