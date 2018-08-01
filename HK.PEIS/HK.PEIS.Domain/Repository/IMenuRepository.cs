using HK.PEIS.Domain.Models;
using System.Linq;

namespace HK.PEIS.Domain
{
    /// <summary>
    /// 菜单聚合根的仓储接口
    /// </summary>
    public interface IMenuRepository:IRepository<TB_MENU>
    {
        IQueryable<TB_MENU> GetMenusByRole(TB_ROLE oRole);
    }
}
