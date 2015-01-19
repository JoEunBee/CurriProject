using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{
    class Controller
    {
        List<Person> bookmark;
        programView painter;
        RequirementData updater;

        public Controller() 
        {
            painter = programView.create();

            // 컨트롤러와 프로그램뷰 객체 둘 다 1개만 존재 가능
            if (painter == null) {
                Console.WriteLine("객체 제한 갯수 초과");
            }

            bookmark = new List<Person>();
            updater = new RequirementData();
        }

        public List<Person> Bookmark
        {
            get;
        }

        public void add(Person clone)
        {
            bookmark.Add(clone);
        }

    }
}
