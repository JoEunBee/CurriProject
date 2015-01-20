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
        String major;
        String track;
        List<Subject> subjects;

        /*********** 읽기 전용 프로퍼티 ***********/

        public List<Subject> Subjects
        {
            get;
        }

        /******************************************/

        // 생성자
        public Requirement(String major, String track) 
        {
            this.major = major;
            this.track = track;
            subjects = new List<Subject>();
        }

        // 이수요건에 과목 추가 메서드
        public void add(Subject clone)
        {
            subjects.Add(clone);
        }


    }
}
