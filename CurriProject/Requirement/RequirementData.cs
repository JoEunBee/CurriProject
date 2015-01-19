using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{
    // 이수요건 객체를 Load 및 Update해주는 객체
    class RequirementData
    {
        List<Requirement> observers;

        public List<Requirement> Observers
        {
            get;
        }

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
