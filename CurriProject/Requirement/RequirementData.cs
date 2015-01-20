using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{
    // 이수요건 관리 객체
    class RequirementData
    {
        List<Requirement> observers;

        /*********** 읽기 전용 프로퍼티 ***********/

        public List<Requirement> Observers
        {
            get;
        }

        /******************************************/

        public void add(Requirement clone)
        {
            observers.Add(clone);
        }

        public void update()
        {
            // 변경사항 적용
        }
    }
}
