using System;
using System.Collections.Generic;


   public class StartUp
    {
       public static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());

            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{years} years= {days} days= {hours} hours= {minutes} minutes.");
        } 
           
    }

