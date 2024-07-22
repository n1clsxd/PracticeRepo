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
        private string TypeStr = "reckonwrit_drill.reflection.SampleClass, reckonwrit drill";
        public UsePrivateConstructor() { } 

        public void Perform()
        {
            Type type = typeof(SampleClass);

            ConstructorInfo constructor = type.GetConstructor(
                BindingFlags.Instance | BindingFlags.NonPublic, 
                null, 
                [typeof(string), typeof(long)], 
                null);

            object instance = constructor.Invoke(["Mansa Musa", 15200000000]);

            SampleClass sampleClass = (SampleClass) instance;

            Console.WriteLine($"Name: {sampleClass.Name} \nGelt: {sampleClass.Money}");
        }


    }
    internal class SampleClass
    {
        public string Name { get; set; }
        public long Money { get; set; }
        private SampleClass(string name, long money) 
        {
            Name = name;
            Money = money;
        }
    }
}
