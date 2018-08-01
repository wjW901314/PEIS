using HK.PEIS.DTO;
using System;
using System.Collections.Generic;

namespace HK.PEIS.WCF.Service
{
    [ServiceClass]
    public class FactoryLayoutWCFService : BaseService,IFactoryLayoutWCFService
    {
        public List<DTO_TM_PLANT> GetAllPlant()
        {
            throw new NotImplementedException();
        }
    }
}
