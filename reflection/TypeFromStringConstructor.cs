using reckonwrit_drill.sample_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reckonwrit_drill.reflection
{
    internal class TypeFromStringConstructor
    {
        private string TypeStr = "reckonwrit_drill.sample_classes.Person, reckonwrit drill";
        public void Perform()
        {
            Type type = Type.GetType(TypeStr);

            object instance = Activator.CreateInstance(type);
            
            Console.WriteLine($"Type of variable named \"{nameof(instance)}\" is {instance.GetType().Name}.");
            
        }
    }
}
