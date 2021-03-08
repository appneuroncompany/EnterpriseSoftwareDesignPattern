using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDesignPattern.Base.Abstract
{
    public interface IModelDal
    {
        public interface IModelDal<TDataModel>
         where TDataModel : class, IDataModel, new()
        {
            void Insert(TDataModel datamodel);
            void DeleteAll();
            TDataModel Select( TDataModel datamodel);

        }
    }
}
