using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Code_Challenge_13
{
    public class Code_Challenge_13
    {

        public static bool ValidateBrackets(string input)
        {
            bool output = true;
            int[] countArr = new int[6];
            string[] stringArr = input.Split("");

            foreach(string test in stringArr)
            {
                switch(test)
                {
                    case "(":
                        countArr[0]++;
                        if(countArr[1] > countArr[0])
                        {
                            output = false;
                        }
                        break;

                    case ")":
                        countArr[1]++;
                        if (countArr[1] > countArr[0])
                        {
                            output = false;
                        }
                        break;

                    case "{":
                        countArr[2]++;
                        if (countArr[3] > countArr[2])
                        {
                            output = false;
                        }
                        break;

                    case "}":
                        countArr[3]++;
                        if (countArr[3] > countArr[2])
                        {
                            output = false;
                        }
                        break;

                    case "[":
                        countArr[4]++;
                        if (countArr[5] > countArr[4])
                        {
                            output = false;
                        }
                        break;

                    case "]":
                        countArr[5]++;
                        if (countArr[5] > countArr[4])
                        {
                            output = false;
                        }
                        break;

                    default:
                        break;

                }
            }

            if(countArr[0] != countArr[1])
            {
                output = false;
            }

            if (countArr[2] != countArr[3])
            {
                output = false;
            }

            if (countArr[4] != countArr[5])
            {
                output = false;
            }

            return output;
        }

    }
}
