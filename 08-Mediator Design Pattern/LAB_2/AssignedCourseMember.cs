using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Mediator_Design_Pattern.LAB_2
{
    public abstract class AssignedCourseMember
    {
        private CoreMediator _coreMediator;

        public AssignedCourseMember(CoreMediator coreMediator)
        {
            this._coreMediator = coreMediator;
        }
    }
}
