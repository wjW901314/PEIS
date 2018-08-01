using HK.PEIS.Infrastructure.MEF;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HK.PEIS.WebBase
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            try
            {
                //注册MEF
                Regisgter.regisgter().ComposeParts(this);
            }
            catch (Exception e)
            {

            }
        }
    }
}
