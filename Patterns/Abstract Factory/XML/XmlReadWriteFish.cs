using Patterns.Abstract_Factory.Interfaces;
using Patterns.Factory_Method.Animals;
using System.Xml.Serialization;

namespace Patterns.Abstract_Factory.XML
{
    class XmlReadWriteFish : IReadWriteFish
    {
        public Fish ReadFish(string s)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Fish));
            using (StringReader textReader = new StringReader(s))
            {
                return (Fish)xmlSerializer.Deserialize(textReader)!;
            }
        }

        public string WriteFish(Fish fish)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(fish.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, fish);
                return textWriter.ToString();
            }
        }
    }
}
