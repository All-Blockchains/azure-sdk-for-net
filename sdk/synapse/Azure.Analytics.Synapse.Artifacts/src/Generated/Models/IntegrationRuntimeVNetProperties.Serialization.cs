// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class IntegrationRuntimeVNetProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VNetId))
            {
                writer.WritePropertyName("vNetId");
                writer.WriteStringValue(VNetId);
            }
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet");
                writer.WriteStringValue(Subnet);
            }
            if (Optional.IsCollectionDefined(PublicIPs))
            {
                writer.WritePropertyName("publicIPs");
                writer.WriteStartArray();
                foreach (var item in PublicIPs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeVNetProperties DeserializeIntegrationRuntimeVNetProperties(JsonElement element)
        {
            Optional<string> vNetId = default;
            Optional<string> subnet = default;
            Optional<IList<string>> publicIPs = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vNetId"))
                {
                    vNetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnet"))
                {
                    subnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicIPs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    publicIPs = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeVNetProperties(vNetId.Value, subnet.Value, Optional.ToList(publicIPs), additionalProperties);
        }
    }
}