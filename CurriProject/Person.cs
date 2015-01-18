using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{
    class Person
    {
        public const int LIMIT_STUDENT_NUMBER = 2008000000; // 08학번부터 이용가능
        String major; 
        String track; 
        int studentNum;
        String name;
        /*********** 읽기 전용 프로퍼티 ***********/

        public String Major{
            get{ return this.major; }
        }

        public String Track
        {
            get { return this.track; }
        }

        public int StudentNum
        {
            get { return this.studentNum; }
        }

        public String Name
        {
            get { return this.Name; }
        }

        /******************************************/

        // 생성자
        public Person(String major, String track, int studentNum, String name)
        {
            // 객체 생성시 값을 잘못 입력한 경우
            if (major == null || track == null || name == null || (studentNum - LIMIT_STUDENT_NUMBER) < 0 )
            {
                // 에러 처리 필요
            }
            // 제대로 생성된 경우
            else
            {
                this.major = major;
                this.track = track;
                this.studentNum = studentNum;
                this.name = name;
            }

        }

    }
}
