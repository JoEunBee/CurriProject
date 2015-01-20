using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{
    // 입력한 Person정보에 맞게 형변환을 해주는 객체
    class PersonFactory
    {
        // Person객체를 학과,트랙에 맞게 형변환해주는 메서드
        public static void create(Person instance)
        {   
           // 컴퓨터 공학과 학생인 경우
            if (instance.Major == "Computer")
            {
                instance = new Person_Computer(instance);
                // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ instance에 이수요건 삽입 필요
            }
        }
    }
}
