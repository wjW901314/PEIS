using HK.PEIS.DTO;
using System.Collections.Generic;
using System.ServiceModel;

namespace HK.PEIS.WCF.Service
{
    /// <summary>
    /// 产品管理模块接口契约
    /// </summary>
    [ServiceContract]
    [ServiceInterface]
    public interface IProductWCFService
    {
        [OperationContract]
        IList<DTO_TP_PRODUCT> GetAllProduct();
    }
}
