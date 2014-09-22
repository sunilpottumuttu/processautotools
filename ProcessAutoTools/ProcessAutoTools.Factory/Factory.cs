using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ProcessAutoTools.ORM;
using My = ProcessAutoTools.POCOS;

namespace ProcessAutoTools.Factory
{
    public static class Factory
    {

        public static My.User GetUsersByUserName(string userName, string passWord)
        {
            using (MyProcessAutoToolsDataContext dc = new MyProcessAutoToolsDataContext())
            {
                var results = (from u in dc.Users 
                               where u.UserName == userName 
                               select new My.User() 
                               { 
                                   UserID = u.UserID, 
                                   UserName = u.UserName 
                               })
                               .FirstOrDefault<My.User>();

                return results;
            }
            
        }


        public static T CreateObject<T>() where T : class
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return CreateObject<T>(assembly);
        }

        public static T CreateObject<T>(Assembly assembly) where T : class
        {
            Type objectType = assembly.GetTypes().FirstOrDefault
            (t => typeof(T).IsAssignableFrom(t) && !t.IsInterface);
            if (null == objectType)
                throw new ApplicationException
                ("No such class found which implement " + typeof(T).Name + " interface");

            object repository = System.Activator.CreateInstance(objectType);
            return (T)repository;
        }

    }


}
