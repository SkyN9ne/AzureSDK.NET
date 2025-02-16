// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageActiveDirectoryProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
            if (Optional.IsDefined(NetBiosDomainName))
            {
                writer.WritePropertyName("netBiosDomainName"u8);
                writer.WriteStringValue(NetBiosDomainName);
            }
            if (Optional.IsDefined(ForestName))
            {
                writer.WritePropertyName("forestName"u8);
                writer.WriteStringValue(ForestName);
            }
            writer.WritePropertyName("domainGuid"u8);
            writer.WriteStringValue(DomainGuid);
            if (Optional.IsDefined(DomainSid))
            {
                writer.WritePropertyName("domainSid"u8);
                writer.WriteStringValue(DomainSid);
            }
            if (Optional.IsDefined(AzureStorageSid))
            {
                writer.WritePropertyName("azureStorageSid"u8);
                writer.WriteStringValue(AzureStorageSid);
            }
            if (Optional.IsDefined(SamAccountName))
            {
                writer.WritePropertyName("samAccountName"u8);
                writer.WriteStringValue(SamAccountName);
            }
            if (Optional.IsDefined(AccountType))
            {
                writer.WritePropertyName("accountType"u8);
                writer.WriteStringValue(AccountType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static StorageActiveDirectoryProperties DeserializeStorageActiveDirectoryProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            Optional<string> netBiosDomainName = default;
            Optional<string> forestName = default;
            Guid domainGuid = default;
            Optional<string> domainSid = default;
            Optional<string> azureStorageSid = default;
            Optional<string> samAccountName = default;
            Optional<ActiveDirectoryAccountType> accountType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("netBiosDomainName"u8))
                {
                    netBiosDomainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("forestName"u8))
                {
                    forestName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainGuid"u8))
                {
                    domainGuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("domainSid"u8))
                {
                    domainSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureStorageSid"u8))
                {
                    azureStorageSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("samAccountName"u8))
                {
                    samAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accountType = new ActiveDirectoryAccountType(property.Value.GetString());
                    continue;
                }
            }
            return new StorageActiveDirectoryProperties(domainName, netBiosDomainName.Value, forestName.Value, domainGuid, domainSid.Value, azureStorageSid.Value, samAccountName.Value, Optional.ToNullable(accountType));
        }
    }
}
