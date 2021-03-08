using RepositoryDesignPattern.Base.Concrete;
using RepositoryDesignPattern.DataModel.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using static RepositoryDesignPattern.Base.Abstract.IModelDal;

namespace RepositoryDesignPattern.DataAccess.Concrete
{
    public class ModelADal : BaseModelDal<DataModelA>, IModelDal<DataModelA>
    {
    }
}
