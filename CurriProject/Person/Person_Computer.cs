using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{
    // 컴퓨터 공학부를 재학중인 학생 객체
    class Person_Computer : Person
    {
        const int MAX_GRADE = 4;
        Requirement requirement;

        public Person_Computer(Person instance) 
            : base(instance.Major, instance.Track, instance.StudentNum, instance.Name)
        {
            requirement = new Requirement();
        }
    }
}
