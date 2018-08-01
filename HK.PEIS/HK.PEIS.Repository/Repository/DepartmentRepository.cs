using HK.PEIS.Domain;
using HK.PEIS.Domain.Models;
using System.ComponentModel.Composition;

namespace HK.PEIS.Repository.Repository
{
    [Export(typeof(IDepartmentRepository))]
    public class DepartmentRepository : EFBaseRepository<TB_DEPARTMENT>, IDepartmentRepository
    {
    }
}
