using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK.PEIS.Web.Service.Factory
{
    public class CreatePowerManagerService
    {
        private static SR_PowerManager.PowerManageWCFServiceClient oPowerManagerClient = null;
        private static object obj = new object();

        public static SR_PowerManager.PowerManageWCFServiceClient GetInstance()
        {
            lock (obj)
            {
                if (oPowerManagerClient == null)
                {
                    oPowerManagerClient = new SR_PowerManager.PowerManageWCFServiceClient();
                }
            }
            return oPowerManagerClient;
        }
    }
}
