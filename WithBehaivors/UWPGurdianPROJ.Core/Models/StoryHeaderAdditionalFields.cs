using Newtonsoft.Json;
using System;

namespace UWPGurdianPROJ.Core.ViewModels
{
    public class StoryHeaderAdditionalFields
    {
        [JsonProperty(PropertyName = "trailText")]
        public string TrailText { get; set; }

        [JsonProperty(PropertyName = "thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty(PropertyName = "headline")]
        public string Headline { get; set; }
    }
}