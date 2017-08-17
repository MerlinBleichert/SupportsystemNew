using Supportsystem.DataLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Supportsystem
{
    public class MachineCatalogueXmlReaderWriter : IReaderWriter<MachineCatalogue>
    {
        XmlSerializer x = new XmlSerializer(typeof(List<HelperElement>));
        public bool Write(MachineCatalogue mc, string filename)
        {
            List<HelperElement> elements = new List<HelperElement>();

            foreach(KeyValuePair<string,Machine> entry in mc.Machines)

            {
                elements.Add(new HelperElement(entry.Key, entry.Value));
            }

            try
            {
                using (FileStream fs = File.Create(filename))
                    x.Serialize(fs, elements);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public MachineCatalogue Read(String filename)
        {
            try
            {
                List<HelperElement> elements;
                using (FileStream fs = File.Open(filename, FileMode.Open))
                    elements = (List<HelperElement>)x.Deserialize(fs);

                MachineCatalogue machines = new MachineCatalogue();

                foreach(HelperElement element in elements)
                {
                    machines.Machines.Add(element.Key, element.Value);
                }

                return machines;

                
            }
            catch
            {
                return new MachineCatalogue(); ;
            }
        }
    }
}
