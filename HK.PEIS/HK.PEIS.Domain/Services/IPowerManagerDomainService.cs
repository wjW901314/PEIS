using HK.PEIS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK.PEIS.Domain
{
    public interface IPowerManagerDomainService
    {
        void AssignPower(TB_USERS oUser, TB_ROLE oRole);
    }
}
