using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{
    // 과목의 정보가 담긴 객체
    class Subject
    {
        String name; // 과목 이름
        int credit; // 학점
        int grade; // 학년
        int semester; // 학기
        String kind; // 분류
        Boolean need; // 필수여부

        /*********** 읽기 전용 프로퍼티 ***********/

        public String Name
        {
            get { return this.name; }
        }

        public int Credit
        {
            get { return this.credit; }
        }

        public int Grade
        {
            get { return this.grade; }
        }

        public int Semester
        {
            get { return this.semester; }
        }

        public String Kind
        {
            get { return this.kind; }
        }

        public Boolean Need
        {
            get { return this.need; }
        }

        /******************************************/

        // 생성자
        public Subject(String name, int credit, int grade,int semester , String kind, Boolean need,)
        {
            if (name == null || kind == null || need == null || credit < 0 || grade < 0 || grade > 4)
            {
                // 생성 에러 
            }
            else
            {
                this.name = name;
                this.credit = credit;
                this.grade = grade;
                this.semester = semester;
                this.kind = kind;
                this.need = need;
            }
        }
    }
}
