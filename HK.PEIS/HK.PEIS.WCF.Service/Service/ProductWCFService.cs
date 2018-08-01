using HK.PEIS.DTO;
using System;
using System.Collections.Generic;

namespace HK.PEIS.WCF.Service
{
    [ServiceClass]
    public class ProductWCFService : BaseService,IProductWCFService
    {
        public IList<DTO_TP_PRODUCT> GetAllProduct()
        {
            throw new NotImplementedException();
        }
    }
}
