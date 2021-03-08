using RepositoryDesignPattern.DataAccess.Concrete;
using System;
using RepositoryDesignPattern.DataModel.Concrete;

namespace RepositoryDesignPattern
{
    /// <summary>
    /// Yazılım uygulamaları genellikle yoğun bir şekilde veritabanı işlemleri gerçekleştiren ekosisteme sahip yapılar olduğundan dolayı, 
    /// ilgili uygulamanın herbir noktasında gerekli veritabanı işlemlerini tekrar tekrar yazmak yerine bu işlemleri tekrar kullanılabilirlik prensibi çerçevesinde daha pratik bir şekilde tek seferde yapmamızı sağlayan bir yapılanma geliştirmemiz gerekecektir.
    /// İşte bu yapılanma Repository sınıfı olacaktır.
    /// </summary>
    public class RepositoryDesign
    {

        public static void TestRepositoryDesign()
        {
            ModelADal modelADal = new ModelADal();
            modelADal.Insert(new DataModelA());
        }
    }
}
