using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{
    class Controller
    {
        List<Person> users; // 사용자 정보를 담아놓는 배열
        programView painter;  // 화면에 그려주는 객체
        RequirementData updater; // 이수요건을 관리하는 객체

        public Controller() 
        {
            painter = programView.create();

            // 컨트롤러와 프로그램뷰 객체 둘 다 1개만 존재 가능
            if (painter == null) {
                Console.WriteLine("객체 제한 갯수 초과");
            }

            users = new List<Person>();
            updater = new RequirementData();
        }

        public List<Person> Users
        {
            get;
        }

        public void add(Person clone)
        {
            users.Add(clone);
        }

    }
}
