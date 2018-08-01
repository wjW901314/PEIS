using HK.PEIS.DTO;
using System.Collections.Generic;
using System.ServiceModel;

namespace HK.PEIS.WCF.Service
{
    /// <summary>
    /// 工厂布局模块接口契约
    /// </summary>
    [ServiceInterface]
    [ServiceContract]
    public interface IFactoryLayoutWCFService
    {
        [OperationContract]
        List<DTO_TM_PLANT> GetAllPlant();
    }
}
