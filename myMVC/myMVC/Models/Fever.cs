using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myMVC.Models
{
    public class Fever
    {
        public float Temp;
        const float Fev = 38;
        const float Hypo = 35;
        public string msg;

        public Fever()
        {
            Temp = 36;
        }

        public static void FeverCheck(Fever fever)
        {
            
            if (fever.Temp >= Fev)
            {
                fever.msg = "u have fever";
            }
            else if (fever.Temp <= Hypo)
            {
                fever.msg = "u have hypothermia";
            }
            else
            {
                fever.msg = "u are okey";
            }
        }
    }
}