// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualWanSecurityProvider
    {
        internal static VirtualWanSecurityProvider DeserializeVirtualWanSecurityProvider(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> url = default;
            Optional<VirtualWanSecurityProviderType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new VirtualWanSecurityProviderType(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualWanSecurityProvider(name.Value, url.Value, Optional.ToNullable(type));
        }
    }
}
