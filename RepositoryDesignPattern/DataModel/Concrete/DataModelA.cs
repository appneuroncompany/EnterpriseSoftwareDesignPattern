using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDesignPattern.DataModel.Concrete
{
    public class DataModelA : IDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
