using reckonwrit_drill.sample_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reckonwrit_drill.reflection
{
    internal class UsePrivateConstructor
    {
        public void Perform()
        {
            Type type = typeof(Person);

            ConstructorInfo constructor = type.GetConstructor(
                BindingFlags.Instance | BindingFlags.NonPublic, 
                null, 
                [typeof(string), typeof(long)], 
                null);

            object instance = constructor.Invoke(["Mansa Musa", 15200000000]);

            Person sampleClass = (Person) instance;
            
            Console.WriteLine($"Name: {sampleClass.Name} \nGelt: {sampleClass.Money}");
        }


    }
    
}
