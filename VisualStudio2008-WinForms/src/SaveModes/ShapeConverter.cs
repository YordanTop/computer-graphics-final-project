using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draw.src.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Draw.src.SaveModes
{
    public class ShapeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Shape);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            
            string type = jsonObject["Type"].ToString().Split(',')[0];
            
            Shape shape;
 
            switch (type)
            {
                case "Draw.RectangleShape":
                    shape = new RectangleShape();
                    break;
                case "Draw.src.Model.LineShape":
                    shape = new LineShape();
                    break;
                case "Draw.src.Model.EllipseShape":
                    shape = new EllipseShape();
                    break;
                case "Draw.src.Model.TriangleShape":
                    shape = new TriangleShape();
                    break;
                default:
                    throw new Exception($"Unknown shape type: {type}");
            }
            serializer.Populate(jsonObject.CreateReader(), shape);
            return shape;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
