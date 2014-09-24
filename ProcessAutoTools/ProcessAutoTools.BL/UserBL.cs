using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCS= ProcessAutoTools.POCOS;
using ProcessAutoTools.ORM;

namespace ProcessAutoTools.BL
{
    public class ProcessAutoToolsBLContext:IDisposable
    {

        private ProcessAutoToolsDataContext db = new ProcessAutoToolsDataContext();

        public PCS.User GetUsersByUserName(string userName, string passWord)
        {
            var results = (from u in this.db.Users
                            where u.UserName == userName
                            select new PCS.User()
                            {
                                UserID = u.UserID,
                                UserName = u.UserName
                            })
                            .FirstOrDefault<PCS.User>();
                
            return results;
        }


        public List<PCS.Project> GetProjects()
        {
            var results = (from p in this.db.Projects
                           select new PCS.Project()
                           {
                               ProjectID = p.ProjectID,
                               ProjectName = p.ProjectName
                           }).ToList<PCS.Project>();
            return results;
        }
        

        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposedValue = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
