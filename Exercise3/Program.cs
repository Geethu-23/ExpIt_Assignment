using System;

namespace ConsoleApp1
{
    class Program

    {
           public static void Main(string[] args)
        {
            Math_1 A = new Math_1();
            
            
            int total_addint=A.MethodAdd(40, 30);
            Console.WriteLine("Total Add int:" + total_addint);

            decimal total_adddecimal = A.MethodAdd(40.6m, 30.3m);
            Console.WriteLine("Total Add decimal:" + total_adddecimal);

            string Total_addstring= A.MethodAdd("444","767");
            Console.WriteLine("Total Add Name:" + Total_addstring);





            int totalsub_int = A.MethodSub(400, 300);
            Console.WriteLine("Total Sub int:" + totalsub_int);

            decimal totalsub_decimal = A.MethodSub(40.6m, 30.3m);
            Console.WriteLine("Total Sub decimal:" + totalsub_decimal);

            string Total_substring = A.MethodSub("800", "500");
            Console.WriteLine("Total Sub Name:" + Total_substring);


            int totaldiv_int = A.Methoddiv(400, 10);
            Console.WriteLine("Total Div int:" + totaldiv_int);

            decimal totaldiv_decimal = A.Methoddiv(300, 9m);
            Console.WriteLine("Total Div decimal:" + totaldiv_decimal);

            string Total_divstring = A.Methoddiv("300", "6");
            Console.WriteLine("Total Div Name:" + Total_divstring);

        }
    }



}