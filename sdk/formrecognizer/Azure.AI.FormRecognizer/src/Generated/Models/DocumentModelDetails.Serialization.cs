// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentModelDetails
    {
        internal static DocumentModelDetails DeserializeDocumentModelDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelId = default;
            Optional<string> description = default;
            DateTimeOffset createdDateTime = default;
            Optional<string> apiVersion = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<IReadOnlyDictionary<string, DocumentTypeDetails>> docTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("docTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, DocumentTypeDetails> dictionary = new Dictionary<string, DocumentTypeDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DocumentTypeDetails.DeserializeDocumentTypeDetails(property0.Value));
                    }
                    docTypes = dictionary;
                    continue;
                }
            }
            return new DocumentModelDetails(modelId, description.Value, createdDateTime, apiVersion.Value, Optional.ToDictionary(tags), Optional.ToDictionary(docTypes));
        }
    }
}
