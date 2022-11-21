﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Human> listOfHumans = new List<Human>();
            listOfHumans.Add(new Human());
            listOfHumans.Add(new Waiter()); /// because of inheritance this is allowed
            //listOfHumans.Add(new Athlete()); // this cannot be done due to incompatible types

            List<IKati> listOfEverybody = new List<IKati>();
            listOfEverybody.Add(new Human());
            listOfEverybody.Add(new Waiter()); 
            listOfEverybody.Add(new Athlete());
            listOfEverybody.Add(new Employee());

            IHuman employee22 = new Employee(); // polymorphism

            Bouzouki bouzouki = new Bouzouki();
            listOfEverybody.Add(bouzouki);     

            // Exercise 1. Create a series of athletes with random data
            // Store these athletes to a List<Athlete>

            // Exercise 2. Create an appropriate list that can hold athletes
            // and coaches (you need to make the class)

            // Exercise 3. Create an instance of a list that holds athletes and their scores
            // class Score (int Id, decimal Perfomance, DateTime DateOfPerformance, int AthletesId)

            // Exercise 4. Create a series methods to a new class (decide the name of the class...)
            // where you need to:
            // A. Find the best athlete's Performance
            // B. Sort the Scores per DateOfPerformance of all the athletes ASCending
            // C. Find the biggest / largest Athlete's Id

            // Exercise 5. Put all the above to a small menu


        }
    }
}
