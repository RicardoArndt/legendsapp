using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Global.DI
{
    public class ServiceLocator
    {
        private static Dictionary<Type, object> Instances = null;
        
        static ServiceLocator()
        {
            Instances = new Dictionary<Type, object>();
        }

        private static void Register<T>()
        {
            Type type = typeof(T);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p));

            Assembly ass = Assembly.GetAssembly(type);

            try
            {
                Instances.Add(typeof(T), ass.CreateInstance(types.FirstOrDefault().FullName));
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        public static T GetInstance<T>()
        {
            try
            {
                if (!Instances.ContainsKey(typeof(T)))
                    Register<T>();

                return (T)Instances[typeof(T)];
            } 
            catch
            {
                throw new Exception("Instance not found.");
            }
            
        }
    }
}
