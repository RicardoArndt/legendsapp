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

        private static void Register<T, F>()
        {
            Type obj = typeof(F);
            Assembly ass = Assembly.GetAssembly(obj);

            try
            {
                Instances.Add(typeof(T), ass.CreateInstance(obj.FullName));
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }

        public static T GetInstance<T, F>()
        {
            try
            {
                if (!Instances.ContainsKey(typeof(T)))
                    Register<T, F>();

                return (T)Instances[typeof(T)];
            } 
            catch
            {
                throw new Exception("Instance not found.");
            }
            
        }
    }
}
