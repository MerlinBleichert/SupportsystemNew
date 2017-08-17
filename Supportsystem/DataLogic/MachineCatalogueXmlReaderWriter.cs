using Supportsystem.DataLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Supportsystem
{
    public class MachineCatalogueXmlReaderWriter : IReaderWriter<MachineCatalogue>
    {
        XmlSerializer x = new XmlSerializer(typeof(MachineCatalogue));
        public bool Write(MachineCatalogue mc, string filename)
        {
            try
            {
                using (FileStream fs = File.Create(filename))
                    x.Serialize(fs, mc);
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
                using (FileStream fs = File.Open(filename, FileMode.Open))
                    return (MachineCatalogue)x.Deserialize(fs);
            }
            catch
            {

                return new MachineCatalogue(); ;
            }
        }
    }
}
