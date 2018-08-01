using HK.PEIS.Domain;
using HK.PEIS.Domain.Models;
using HK.PEIS.DTO;
using HK.PEIS.Infrastructure.MEF;
using Serialize.Linq.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq.Expressions;

namespace HK.PEIS.WCF.Service
{
    [ServiceClass]
    public class PowerManageWCFService : BaseService, IPowerManageWCFService
    {
        #region Fields
        [Import]
        private IUserRepository userRepository { get; set; }

        [Import]
        private IDepartmentRepository departmentRepository { get; set; }

        [Import]
        private IRoleRepository roleRepository { get; set; }

        [Import]
        private IMenuRepository menuRepository { get; set; }
        #endregion

        #region Constust
        public PowerManageWCFService()
        {
            //注册MEF
            Regisgter.regisgter().ComposeParts(this);
        }
        #endregion

        #region 用户管理
        //这里参数为什么不直接用Expression<Func<DTO_TB_USERS,bool>>这种类型，是因为Expression不支持序列化，无法用于WCF数据的传递
        public List<DTO_TB_USERS> GetUsers(ExpressionNode expressionNode)
        {
            Expression<Func<DTO_TB_USERS, bool>> selector = null;
            if (expressionNode != null)
            {
                selector = expressionNode.ToExpression<Func<DTO_TB_USERS, bool>>();
            }
            var lstRes = base.GetDtoByLamada<DTO_TB_USERS, TB_USERS>(userRepository, selector);
            return lstRes;
        }

        public DTO_TB_USERS AddUser(DTO_TB_USERS oUser)
        {
            return base.AddDto<DTO_TB_USERS, TB_USERS>(userRepository, oUser);
        }

        public bool DeleteUser(DTO_TB_USERS oUser)
        {
            var bRes = false;
            try
            {
                base.DeleteDto<DTO_TB_USERS, TB_USERS>(userRepository, oUser);
                bRes = true;
            }
            catch
            {

            }
            return bRes;
        }

        public bool DeleteUserByLamada(ExpressionNode expressionNode)
        {
            Expression<Func<DTO_TB_USERS, bool>> selector = null;
            if (expressionNode != null)
            {
                selector = expressionNode.ToExpression<Func<DTO_TB_USERS, bool>>();
            }
            var bRes = false;
            try
            {
                base.DeleteDto<DTO_TB_USERS, TB_USERS>(userRepository, selector);
                bRes = true;
            }
            catch
            {

            }
            return bRes;
        }

        public bool UpdateUser(DTO_TB_USERS oUser)
        {
            var bRes = false;
            try
            {
                base.UpdateDto<DTO_TB_USERS, TB_USERS>(userRepository, oUser);
                bRes = true;
            }
            catch
            {

            }
            return bRes;
        }
        #endregion

        #region 部门管理
        public List<DTO_TB_DEPARTMENT> GetDepartments(ExpressionNode expressionNode)
        {
            Expression<Func<DTO_TB_DEPARTMENT, bool>> selector = null;
            if (expressionNode != null)
            {
                selector = expressionNode.ToExpression<Func<DTO_TB_DEPARTMENT, bool>>();
            }
            return base.GetDtoByLamada<DTO_TB_DEPARTMENT, TB_DEPARTMENT>(departmentRepository, selector);
        }
        public DTO_TB_DEPARTMENT AddDepartment(DTO_TB_DEPARTMENT oDept)
        {
            return base.AddDto<DTO_TB_DEPARTMENT, TB_DEPARTMENT>(departmentRepository, oDept);
        }

        public bool DeleteDepartment(DTO_TB_DEPARTMENT oDept)
        {
            var bRes = false;
            try
            {
                base.DeleteDto<DTO_TB_DEPARTMENT, TB_DEPARTMENT>(departmentRepository, oDept);
                bRes = true;
            }
            catch
            {

            }
            return bRes;
        }

        public bool DeleteDeptByLamada(ExpressionNode expressionNode)
        {
            Expression<Func<DTO_TB_DEPARTMENT, bool>> selector = null;
            if (expressionNode != null)
            {
                selector = expressionNode.ToExpression<Func<DTO_TB_DEPARTMENT, bool>>();
            }
            var bRes = false;
            try
            {
                base.DeleteDto<DTO_TB_DEPARTMENT, TB_DEPARTMENT>(departmentRepository, selector);
                bRes = true;
            }
            catch
            {

            }
            return bRes;
        }

        public bool UpdateDepartment(DTO_TB_DEPARTMENT oDept)
        {
            var bRes = false;
            try
            {
                base.UpdateDto<DTO_TB_DEPARTMENT, TB_DEPARTMENT>(departmentRepository, oDept);
                bRes = true;
            }
            catch
            {

            }
            return bRes;
        }
        #endregion

        #region 角色管理
        public List<DTO_TB_ROLE> GetRoles(ExpressionNode expressionNode)
        {
            Expression<Func<DTO_TB_ROLE, bool>> selector = null;
            if (expressionNode != null)
            {
                selector = expressionNode.ToExpression<Func<DTO_TB_ROLE, bool>>();
            }
            return base.GetDtoByLamada<DTO_TB_ROLE, TB_ROLE>(roleRepository, selector);
        }

        public DTO_TB_ROLE AddRole(DTO_TB_ROLE oRole)
        {
            return base.AddDto<DTO_TB_ROLE, TB_ROLE>(roleRepository, oRole);
        }
        #endregion

        #region 菜单管理
        public List<DTO_TB_MENU> GetMenus(ExpressionNode expressionNode)
        {
            Expression<Func<DTO_TB_MENU, bool>> selector = null;
            if (expressionNode != null)
            {
                selector = expressionNode.ToExpression<Func<DTO_TB_MENU, bool>>();
            }
            return base.GetDtoByLamada<DTO_TB_MENU, TB_MENU>(menuRepository, selector);
        }

        public DTO_TB_MENU AddMenu(DTO_TB_MENU oMenu)
        {
            return base.AddDto<DTO_TB_MENU, TB_MENU>(menuRepository, oMenu);
        }
        #endregion
    }
}
