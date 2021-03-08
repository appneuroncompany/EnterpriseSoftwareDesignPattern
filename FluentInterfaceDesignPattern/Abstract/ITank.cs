using System;
using System.Collections.Generic;
using System.Text;

namespace FluentInterfaceDesignPattern.Abstract
{
    public interface ITank
    {
        ITank Fire();
        ITank Defence();
        ITank GetItem();
    }
}
