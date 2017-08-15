using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Supportsystem
{
    public class ReadWrite
    {
        public static bool Write(MachineCatalogue mc, string filename)
        {
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(MachineCatalogue));
                using (FileStream fs = File.Create(filename))
                    x.Serialize(fs, mc);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public static MachineCatalogue Read(String filename)
        {
            MachineCatalogue mc = new MachineCatalogue();
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(MachineCatalogue));
                using (FileStream fs = File.Open(filename, FileMode.Open))
                    mc = (MachineCatalogue)x.Deserialize(fs);

                return mc;
            }
            catch
            {

                return mc;
            }
        }
    }
}
