using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurriProject
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Controller controller = new Controller();

            /* 사용자 입력 */
            String major = "컴퓨터공학과";
            String track = "H/W";
            int studentNum = 2013136134;
            String name = "최준혁";


            Person person = new Person(major,track,studentNum,name);

            PersonFactory.create(person);

            controller.add(person);

        }

    }
}
