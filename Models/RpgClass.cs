using System.Text.Json.Serialization;

namespace dontet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Mercenary = 1,
        Mage = 2
    }
}