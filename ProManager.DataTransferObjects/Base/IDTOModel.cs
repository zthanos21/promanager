using ProManager.Enumerators;
using System;

namespace ProManager.DataTransferObjects.Base
{
    public interface IDTOModel<TEntity> where TEntity : class
    {
        DTOState DTOState { get; set; }

        Guid Id { get; set; }

        TEntity ToModel();
        void UpdateModel(TEntity model);
        // object[] GetKeys();
    }
}
