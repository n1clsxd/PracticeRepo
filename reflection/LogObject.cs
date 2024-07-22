using reckonwrit_drill.sample_classes;
using System;
using System.Reflection;
using System.Text;

namespace reckonwrit_drill.reflection
{
    internal class LogObject
    {
        internal void Perform()
        {
            Person person = new() { Name= "Tokugawa", Money = 100000};
            
            Log(person);
        }

        private void Log(object obj)
        {
            if (obj == null) return;

            StringBuilder sb = new StringBuilder(); 

            Type type = obj.GetType();

            foreach (PropertyInfo p in type.GetProperties()) 
            {
                sb.AppendLine(p.Name + ": " + p.GetValue(obj));
            }

            Console.Write(sb.ToString());
        }
    }
}
