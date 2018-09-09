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
        protected static Dictionary<Type, object> Instances = null;
        
        public ServiceLocator()
        {
            Instances = new Dictionary<Type, object>();
        }
        
        public void Register<T, F>()
        {
            Type obj = typeof(F);
            Assembly ass = Assembly.GetAssembly(obj);

            try
            {
                if(!Instances.ContainsKey(typeof(T)))
                    Instances.Add(typeof(T), ass.CreateInstance(obj.FullName));
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
                return (T)Instances[typeof(T)];
            } 
            catch
            {
                throw new Exception("Instance not found.");
            }
            
        }
    }
}
