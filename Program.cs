
using System;

namespace Shenase_Melli
{
    class Program
    {
        static void Main(string[] args)
        {

            string id;
            do
            {
                System.Console.WriteLine("Please Enter Your Shenase Id :");
                id = Console.ReadLine();
            } while (id.Length != 11);

            spell(id);


        }

        public static void spell(string national_id)
        {
            int[] sp = new int[11];
            for (var i = 0; i < 11; i++)
            {
                sp[i] = int.Parse(national_id.Substring(i, 1));
            }

            division(sp);


        }

        public static bool division(int[] s)
        {
            int sum = 0;
            int count = 2;
            int[] zairb = new int[]{29,27,23,19,17,29,27,23,19,17};
            for (int i = 0; i < 10; i++)
            {
                s[i] = (s[9] + count) + s[i];
              
            }
            // foreach (var item in s)
            // {
            //     System.Console.WriteLine(item);  
            // }
            for (int i = 0; i < 10; i++)
            {
                sum = sum + (s[i] * zairb[i]);
            }
           
            
                System.Console.WriteLine(sum);
            


            bool res = check(sum, s[10]);
            System.Console.WriteLine(res);

            return res;

        }

        public static bool check(int summary, int controller)
        {
            int remain = summary % 11;
            
           if (remain == controller)
           {
               return true;
           } 
           
          else if (remain == 10)
           {
               remain = 0;
               if (remain == controller)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           else
           {
               return false;
           }
         
           

        }



    }
}
