using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK.PEIS.WCF.Service
{
    /// <summary>
    /// 标记此特性的为WCF服务接口
    /// </summary>
    public class ServiceInterfaceAttribute:Attribute
    {

    }

    /// <summary>
    /// 标记此特性的为WCF服务接口实现类
    /// </summary>
    public class ServiceClassAttribute : Attribute
    {

    }
}
