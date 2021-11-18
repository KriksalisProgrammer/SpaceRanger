using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Galactic.Models.IO
{
    public  class  IoController
    { 
        public void SerializeAndSave(int NumberBattle, List<string> data)
        {
            string nameFile = $"Battle{NumberBattle}";
            string fileName = Path.Combine(Environment.CurrentDirectory, $"{nameFile}.txt");
            var serializer = new XmlSerializer(typeof(List<string>));
            using (var writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, data);
            }
        }
    }
}
