using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp_TT2_Fact
{
    class Factorial
    {
        public string S { get; set; }
        public int CheckN { get; set; }
        private bool flag = false;

        public void checkn(int N)
        {
            try
            {
                if (N >= 1 && N <= Fact(2000))
                {
                    S = "You enter number = " + N.ToString() + " is correct ";
                    flag = true;
                }
                else
                {
                   S = "Input number is not correct";
                   flag = false;
                }
            }
            catch (Exception ex)
            {
                S = ex.ToString();
            }

        }

        
        public void rev_Fact(int N)
        {
            int r = 1;
            CheckN = -1;

            for (int i = 1; i <= N; ++i)
            {
                r *= i;

                if (N == r)
                {
                    CheckN = i;
                    break;
                }
            }

            if (CheckN != -1)
            {
                S = "Answer = " + CheckN.ToString();
                flag = true;
            }
            else
            {
                S = "Answer is no found";
                flag = false;
            }
        }

        private double Fact(int N)
        {
            if (N == 1)
                 return 1;
            return N * Fact(N - 1);           
        }

        public void check_correct_answer (int N)
        {
            if (flag == true)
            {
                rev_Fact(N);
                if (N == Fact(CheckN))
                    S = "Answer = " + CheckN.ToString() + " \n" + N.ToString() + " = " + CheckN.ToString() + "!" + " (" + CheckN.ToString() + "! = " + Fact(CheckN) + ")";
                else
                    S = "Answer is no found";
            }
            else
                S = "Answer is no found";

        }

       
    }
}
