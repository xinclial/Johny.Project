using Johny.Project.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class WorkServices : IDisposable
    {
        private DataModelEntity context = new DataModelEntity();

        private GenericRepository<VM_R_Base> vm_R_BaseRepository;

        private GenericRepository<VM_R_Certification> vm_R_CertificationRepository;

        public GenericRepository<VM_R_Base> VM_R_BaseRepository
        {
            get
            {
                if (this.vm_R_BaseRepository == null)
                {
                    this.vm_R_BaseRepository = new GenericRepository<VM_R_Base>(context);
                }
                return vm_R_BaseRepository;
            }
        }

        public GenericRepository<VM_R_Certification> VM_R_CertificationRepository
        {
            get
            {
                if (this.vm_R_CertificationRepository == null)
                {
                    this.vm_R_CertificationRepository = new GenericRepository<VM_R_Certification>(context);
                }
                return vm_R_CertificationRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
