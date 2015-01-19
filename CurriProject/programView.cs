﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriProject
{
    // 화면에 정보를 띄워주는 객체(싱글턴)
    class programView
    {
        public static programView progView;
        private programView()
        {
        }

        public static programView create()
        {
            if (progView == null)
            {
                progView = new programView();
                return progView;
            }
            else
                return null;
        }
    }
}
