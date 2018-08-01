using HK.PEIS.Domain;
using HK.PEIS.Domain.Models;
using System.ComponentModel.Composition;

namespace HK.PEIS.Repository
{
    [Export(typeof(IRoleRepository))]
    public class RoleRepository : EFBaseRepository<TB_ROLE>, IRoleRepository
    {

    }
}
