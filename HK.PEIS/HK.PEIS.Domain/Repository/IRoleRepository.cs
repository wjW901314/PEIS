using HK.PEIS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK.PEIS.Domain
{
    /// <summary>
    /// 角色这个聚合根的仓储接口
    /// </summary>
    public interface IRoleRepository : IRepository<TB_ROLE>
    {
    }
}
