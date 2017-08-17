using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    [Serializable]
    public class HelperElement
    {
        public string Key { get; set; }
        public Machine Value { get; set; }

        public HelperElement() { }

        public HelperElement(string key, Machine value)
        {
            Key = key;
            Value = value;
        }
    }
}
