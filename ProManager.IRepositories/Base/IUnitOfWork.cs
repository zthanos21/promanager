using ProManager.Entities;

namespace ProManager.IRepositories.Base
{
    public interface IUnitOfWork
    {
        ProManagerContext DbContext { get; }
        ISaveContextModel Save();
    }

    public class ISaveContextModel
    {
        public int Status { get; set; }
        public string Messages { get; set; }
    }
}
