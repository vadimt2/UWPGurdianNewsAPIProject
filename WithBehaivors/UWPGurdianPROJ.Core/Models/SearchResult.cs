using Newtonsoft.Json;

namespace UWPGurdianPROJ.Core.ViewModels
{
    public class SearchResult
    {
        [JsonProperty(PropertyName = "response")]
        public SearchResponse SearchResponse { get; set; }
    }
}