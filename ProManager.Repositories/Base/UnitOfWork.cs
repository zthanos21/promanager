using ProManager.Entities;
using ProManager.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProManager.Repositories.Base
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private Entities.ProManagerContext context;

        public UnitOfWork()
        {
        }


        public ProManagerContext DbContext
        {
            get
            {
                //if (context == null)
                //{
                //    context = new ProManagerContext();
                //}

                return context;
            }
        }

        public ISaveContextModel Save()
        {
            var res = new ISaveContextModel();
            try
            {
                DbContext.SaveChanges();
                res.Status = 0;
            }
            catch (Exception ex)
            {
                res.Status = 1;
                var errors = DbContext.ChangeTracker.Entries();
              //  var valErrors = DbContext.GetValidationErrors();
                //if (valErrors.)
                if (ex.InnerException != null)
                    res.Messages = ex.InnerException.InnerException.Message;
                else
                    res.Messages = ex.Message;
                //throw ex;

            }
            return res;
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
