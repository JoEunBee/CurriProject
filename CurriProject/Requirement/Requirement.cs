using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{
    // 학과, 트랙별 이수요건 객체
    class Requirement
    {
        List<Subject> subjects;

        /*********** 읽기 전용 프로퍼티 ***********/

        public List<Subject> Subjects
        {
            get;
        }

        /******************************************/

        // 생성자
        public Requirement() 
        {
            subjects = new List<Subject>();
        }
    
        public void add(Subject clone)
        {
            subjects.Add(clone);
        }


    }
}
