﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("Enter user name");
            userName = Console.ReadLine();
            if(userName.Length>=6)
            {
                Console.WriteLine("Welcome : \t " + userName);
        
            }
            else
            {
                Console.WriteLine("Invalid User Name");
            }
            Console.ReadKey();
        }
    }
}
