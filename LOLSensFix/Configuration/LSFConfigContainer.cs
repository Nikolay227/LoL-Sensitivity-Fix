using Newtonsoft.Json;

namespace LOLSensFix.Configuration
{
    internal class LsfConfigContainer
    {
        [JsonProperty("static_sensitivity_value")]
        public int StaticSensitivityValue { get; set; } = 5;
    }
}
