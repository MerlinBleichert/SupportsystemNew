using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem.DataLogic
{
    public interface IReaderWriter<T>
    {
         bool Write(T mc, string filename);

         T Read(String filename);
    }
}
