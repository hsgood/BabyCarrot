using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyCarrot.Extensions
{
    //클래스를 static 으로 선언해야 한다
    public static class StringExtensions  
    {
        //메소드를 static 으로 선언 한다
        //파라메터 첫번째는 this로 선언하는 클래스가 온다
        public static bool IsNumeric(this string s)
        {
            long result;
            return long.TryParse(s, out result);
        }

        public static bool IsDateTime(this string s)
        {
            if(String.IsNullOrEmpty(s))
            {
                return false;
            }
            else
            {
                DateTime result;
                return DateTime.TryParse(s, out result);
            }
        }
    }
}
