using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Extension
{
    public static class Extension
    {
        public static bool Find(this string sentence, string part)
        {
            bool result = false;
            int thepartcount = 0;
            

            for (int i = 0, a=0; i < sentence.Length; i++)
            {
                if (sentence[i] == part[a])
                {
                   a++;
                   thepartcount++;
                    
                }
                else
                 {
                    a = 0;
                    thepartcount = 0;
                }
                if (thepartcount==part.Length)
                {
                    result = true;
                    break;
                }
               
            }
            return result;
           

        }

    }
}
