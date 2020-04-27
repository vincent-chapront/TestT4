using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ResourceToJs
{
    class Program
    {
        static void Main(string[] args)
        {
            ResourceManager MyResourceClass = new ResourceManager(typeof(ResourceToJs.Properties.Resources /* Reference to your resources class -- may be named differently in your case */));

            ResourceSet resourceSet = MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceKey = entry.Key.ToString();
                object resource = entry.Value;
            }
        }
    }
}
