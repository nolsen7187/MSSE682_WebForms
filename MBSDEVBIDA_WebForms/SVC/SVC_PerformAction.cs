using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Xml;

using SVC;
using DAL;

namespace SVC
{
    public class SVC_PerformAction
    {
        private static Int16 actionType;
        private Type ClassType;

        //Method used for websites
        public void Action(Object Class, int ActionType)
        {
            dynamic ClassObject = Class;
            string ClassType = Class.ToString();

            if (ClassType == "DAL.Customer")
            {
                var Repo = SVC_RepositoryConcreteClass.CRUD<Customer>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.Employee")
            {
                var Repo = SVC_RepositoryConcreteClass.CRUD<Employee>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.Item")
            {
                var Repo = SVC_RepositoryConcreteClass.CRUD<Item>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.ItemCategory")
            {
                var Repo = SVC_RepositoryConcreteClass.CRUD<ItemCategory>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.SalesHeader")
            {
                var Repo = SVC_RepositoryConcreteClass.CRUD<SalesHeader>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.SalesItem")
            {
                var Repo = SVC_RepositoryConcreteClass.CRUD<SalesItem>();
                Act(Repo, ClassObject, ActionType);
            }
            else if (ClassType == "DAL.WebUserTable")
            {
                var Repo = SVC_RepositoryConcreteClass.CRUD<WebUserTable>();
                Act(Repo, ClassObject, ActionType);
            }
        }
        public void Act(IDataRepository DataRepo, dynamic ClassObject, int ActionType)
        {
            switch (ActionType)
            {

                case 1://Create
                    DataRepo.Create(ClassObject);
                    break;
                case 2://Update
                    DataRepo.Update(ClassObject);
                    break;
                case 3://Delete
                    DataRepo.Delete(ClassObject);
                    break;
                default:
                    break;
            }
        }
        //End of logic used by websites
    }

}
