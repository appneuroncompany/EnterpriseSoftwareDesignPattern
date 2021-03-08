using FluentInterfaceDesignPattern.Concrete;
using System;

namespace FluentInterfaceDesignPattern
{
    /// <summary>
    /// Sizlere aslen bir Design Pattern olan Fluent Interface yapısından bahsedeceğim. Fluent, “akıcı” anlamına gelen bir kelimedir. 
    /// Yani kod yazarken belli başlı durumlarda daha net ve akıcı kod yazmamızı sağlayan bir tasarım deseninidir.
    /// Asıl mevzu, bir nesnenin metodlarının aynı türde bir nesne geri döndürdüğü bir modeldir. 
    /// Tabi ki de bu nesne, o anki “this” keywordü ile ifade ettiğimiz nesnenin ta kendisi olacaktır.
    /// </summary>
    public class FluentInterfaceDesign
    {
        public static void TestFluentInterface()
        {
            Tank tank = new Tank();
            tank.Defence()
                .GetItem()
                .Fire()
                .Defence();
        }
    }
}
