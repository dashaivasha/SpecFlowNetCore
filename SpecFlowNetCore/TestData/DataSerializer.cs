﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace SpecFlowNetCore.TestData
{
    public class DataSerializer
    {
        public static object JsonDeserialize(Type dataType, string filePath)
        {
            try
            {
                JObject obj = null;

                var jsonSerializer = new JsonSerializer
                {
                    DateParseHandling = DateParseHandling.None
                };

                if (File.Exists(filePath))
                {
                    var sr = new StreamReader(filePath);
                    var jsonReader = new JsonTextReader(sr);

                    obj = jsonSerializer.Deserialize(jsonReader) as JObject;
                    jsonReader.Close();
                    sr.Close();
                }

                return obj.ToObject(dataType);
            }
            catch
            {
                throw;
            }
        }
    }
}
