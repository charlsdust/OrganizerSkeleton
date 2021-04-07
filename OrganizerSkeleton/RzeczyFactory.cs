using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using OrganizerSkeleton.Rzeczy;

namespace OrganizerSkeleton
{
    public class RzeczyFactory
    {
        Dictionary<string, Type> rzeczy;
        public RzeczyFactory()
        {
            LoadTypesICanReturn();
        }
        public IRzecz GetRzecz(string name)
        {
            Type t = GetTypeToCreate(name);
            if (t == null)
                return new NullRzecz();
            return Activator.CreateInstance(t) as IRzecz; 

        }
        private Type GetTypeToCreate(string name)
        {
            foreach (var rzecz in rzeczy)
            {
                if(rzecz.Key.Contains(name))
                {
                    return rzeczy[rzecz.Key];
                }
              
            }  return null;

        }

        private void LoadTypesICanReturn()
        {
            rzeczy = new Dictionary<string, Type>();
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in typesInThisAssembly)
            {
               if( type.GetInterface(typeof(IRzecz).ToString())!=null)
                {
                    rzeczy.Add(type.Name.ToLower(), type);
                }

            }
        }
    }
}
