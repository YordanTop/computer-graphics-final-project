using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Draw.src.SaveModes
{
    public class JsonModel
    {

        public static string SaveAs(List<Shape> ListOfPrimitives)
        {
            ListOfPrimitives.ForEach(x => { x.IsGrouped = false; });

            string json = JsonConvert.SerializeObject(ListOfPrimitives, Formatting.Indented);
            return json;
        }

        public static List<Shape> ReadJson(string json)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;
            settings.Converters.Add(new ShapeConverter());

            List<Shape> list = JsonConvert.DeserializeObject<List<Shape>>(json,settings);
            return list;
        }
    }
}
