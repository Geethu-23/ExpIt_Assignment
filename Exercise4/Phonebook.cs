using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Phonebook
    {

      static string[] phoneno = new string[50];
        int count = 0;

        public void insertNumber(string[] phoneno)
        {
            Console.WriteLine(phoneno[2]);

        }
        public void Display(string[] PhoneNO)
        {
            count = PhoneNO.Length;
            Console.WriteLine(PhoneNO[0]);
            Console.WriteLine(count);
        }
        public static void Main(string[] args) {

            Phonebook PB = new Phonebook();
             string[] phoneno = {"1234588374","3254234890", "3654567811"};
             
            PB.Display(phoneno);
            PB.insertNumber(phoneno);
                
        }


    }
}
