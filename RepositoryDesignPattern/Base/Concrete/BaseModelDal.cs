using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDesignPattern.Base.Concrete
{
    public class BaseModelDal<TDataModel>
    where TDataModel : class, IDataModel, new()
    {

        public void Insert(TDataModel datamodel)
        {
            Console.WriteLine("Smt oprations... for insert");
        }

        public void DeleteAll()
        {
            Console.WriteLine("Smt oprations... for delete");
        }

        public TDataModel Select(TDataModel datamodel)
        {
            Console.WriteLine("Smt oprations... for select");
            return null;
        }



    }

}
