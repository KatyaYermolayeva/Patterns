using Patterns.Abstract_Factory.Interfaces;
using Patterns.Factory_Method.Animals;
using System.Xml.Serialization;

namespace Patterns.Abstract_Factory.XML
{
    class XmlReadWriteBird : IReadWriteBird
    {
        public Bird ReadBird(string s)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bird));
            using (StringReader textReader = new StringReader(s))
            {
                return (Bird)xmlSerializer.Deserialize(textReader)!;
            }
        }

        public string WriteBird(Bird bird)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(bird.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, bird);
                return textWriter.ToString();
            }
        }
    }
}
