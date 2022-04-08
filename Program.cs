using System;
using dotnet.src.Entities;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.Write(wizard.Attack());

        }
    }
}