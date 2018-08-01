using HK.PEIS.Domain;
using HK.PEIS.Domain.Models;
using HK.PEIS.Infrastructure.MEF;
using System;
using System.ComponentModel.Composition;
using System.Linq;

namespace HK.PEIS.WCF.Service
{
    class Program
    {
        [Import]
        public IUserRepository userRepository { get; set; }

        [Import]
        public IMenuRepository menuRepository { get; set; }

        [Import(AllowDefault = false, AllowRecomposition = true, RequiredCreationPolicy = CreationPolicy.Any, Source = ImportSource.Any)]
        public IPowerManagerDomainService powerDomainService { get; set; }

        static void Main(string[] args)
        {
            //注册MEF
            //var oProgram = new Program();
            //Regisgter.regisgter().ComposeParts(oProgram);
            //var lstFindUsers = oProgram.userRepository.Find(x => x.USER_NAME != null);
            //var lstRes = lstFindUsers.ToList();
            //var lstMenu = oProgram.menuRepository.GetMenusByRole(new TB_ROLE() { ROLE_ID =111 });
            //var lstMenuRes = lstMenu.ToList();


            //var oProgram = new Program();
            //Regisgter.regisgter().ComposeParts(oProgram);
            //var oUser = new TB_USERS() { USER_ID = 3 };
            //var oRole = new TB_ROLE() { ROLE_ID = 11 };
            //oProgram.powerDomainService.AssignPower(oUser, oRole);

            //Console.ReadKey();


            var oBootstrapper = new Bootstrapper();
            oBootstrapper.StartServices();
            Console.ReadLine();
        }
    }
}
