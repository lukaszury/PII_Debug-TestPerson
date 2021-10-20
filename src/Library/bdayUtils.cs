using System;
using System.Collections;

namespace UnitTestAndDebug
{
    public class bdayUtils
    {
        public static bool bdayIsValid(string birthday)
        {
            String[] birthdayDate = birthday.Split("/");
            var day = int.Parse(birthdayDate[0]);
            var month = int.Parse(birthdayDate[1]);
            var year = int.Parse(birthdayDate[2]);
            if(day >= 1 && day<= 30 && month >= 1 && month <= 12 && year >= 1900)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}