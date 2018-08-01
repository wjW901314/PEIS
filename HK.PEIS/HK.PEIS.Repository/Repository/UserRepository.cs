using HK.PEIS.Domain;
using HK.PEIS.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace HK.PEIS.Repository
{
    [Export(typeof(IUserRepository))]
    public class UserRepository : EFBaseRepository<TB_USERS>, IUserRepository
    {
        public IEnumerable<TB_USERS> GetUsersByRole(TB_ROLE oRole)
        {
            throw new NotImplementedException();
        }
    }
}
