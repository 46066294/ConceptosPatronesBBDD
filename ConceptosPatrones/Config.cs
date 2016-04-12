using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ConceptosPatrones
{
    public class Config
    {
        readonly static Config _instance;

        static Config()
        {
            _instance = getInstance();
        }

        static Config getInstance()
        {
            var json = File.ReadAllText("Config.json");
            return JsonConvert.DeserializeObject<Config>(json);
        }

        private Config()
        {
        }

        public static Config Instance
        {
            get
            {
                return _instance;
            }
        }

        [JsonProperty("ConnectionType", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConnectionType ConnectionType { get; private set; }

    }
}
