// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductLink
    {
        internal static ProductLink DeserializeProductLink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProductLinkType> linkType = default;
            Optional<Uri> linkUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linkType = new ProductLinkType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("linkUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        linkUrl = null;
                        continue;
                    }
                    linkUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ProductLink(Optional.ToNullable(linkType), linkUrl.Value);
        }
    }
}
