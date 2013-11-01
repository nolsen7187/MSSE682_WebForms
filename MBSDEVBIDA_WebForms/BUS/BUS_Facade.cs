using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVC;

namespace BUS
{
    public class BUS_Facade
    {
        private Object lclObjectClass;

        public Facade(Object Object, int ActionType)
        {   
            this.lclObjectClass = Object;
            this.lclActionType = ActionType;
        }
        public void ProcessRequest()
        {
            performAction.Action(lclObjectClass, lclActionType);
        }
    }
}
