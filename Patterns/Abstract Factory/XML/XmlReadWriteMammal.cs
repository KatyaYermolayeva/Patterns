using Patterns.Abstract_Factory.Interfaces;
using Patterns.Factory_Method.Animals;
using System.Xml.Serialization;

namespace Patterns.Abstract_Factory.XML
{
    class XmlReadWriteMammal : IReadWriteMammal
    {
        public Mammal ReadMammal(string s)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Mammal));
            using (StringReader textReader = new StringReader(s))
            {
                return (Mammal)xmlSerializer.Deserialize(textReader)!;
            }
        }

        public string WriteMammal(Mammal mammal)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(mammal.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, mammal);
                return textWriter.ToString();
            }
        }
    }
}
