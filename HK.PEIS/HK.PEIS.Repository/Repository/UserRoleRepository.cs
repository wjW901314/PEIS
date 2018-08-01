using HK.PEIS.Domain;
using HK.PEIS.Domain.Models;
using System.ComponentModel.Composition;

namespace HK.PEIS.Repository.Repository
{
    [Export(typeof(IUserRoleRepository))]
    public class UserRoleRepository : EFBaseRepository<TB_USERROLE>, IUserRoleRepository
    {
    }
}
