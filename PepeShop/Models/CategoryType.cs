using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PepeShop.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryType
    {
        [EnumMember]
        Unknown,
        [EnumMember]
        Mobile,
        [EnumMember]
        Desktop
    }
}
