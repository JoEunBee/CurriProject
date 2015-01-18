using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{

    class PersonFactory
    {
        public static object create(object clone)
        {
            Person instance = new Person("", "", Person.LIMIT_STUDENT_NUMBER+1, ""); // Person 객체 생성

            // clone이 Person 객체형식인 경우
            if ( clone.GetType() == instance.GetType() )
            {
                instance = (Person) clone;
                
                // 컴퓨터 공학과 학생인 경우
                if (instance.Major == "Computer")
                {
                    instance = new Person_Computer();
                }

                // 생성된 인스턴스 반환
                return instance;
            }

            // clone이 Person 객체형식이 아닌 경우
            else
                return null;
            
        }
    }
}
