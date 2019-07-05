using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvatarResourceUpdate.Json
{
    class Visualizations
    {
        public string type { get; set; }

        [JsonProperty(PropertyName = "1")]
        public Visualization Size1 { get; set; }

        [JsonProperty(PropertyName = "32")]
        public Visualization Size32 { get; set; }

        [JsonProperty(PropertyName = "64")]
        public Visualization Size64 { get; set; }
    }
    class Visualization
    {
        public string size { get; set; }
        public string layerCount { get; set; }
        public string angle { get; set; }
        public List<Layer> layers { get; set; }
        public Dictionary<string, List<string>> directions { get; set; }
        public Dictionary<string, List<Color>> colors { get; set; }

    }
    class Layer
    {
        public string id { get; set; }
        public string z { get; set; }
    }

    class Direction { }
    class Color
    {
        public int layerId { get; set; }
        public string color { get; set; }
    }
}