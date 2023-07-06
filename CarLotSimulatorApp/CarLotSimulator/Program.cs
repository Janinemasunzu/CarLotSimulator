﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            CarLot carLot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car car = new Car();
            car.Make = "Hyundai";
            car.Model = "Tuscon";
            car.Year = 2022;
            car.EngineNoise = "vroom";
            car.HonkNoise = "beep";
            car.IsDrivable = true;

            CarLot.numberOfCars = 1;
            Console.WriteLine($"The number of cars in carlot is {CarLot.numberOfCars}");
            CarLot.numberOfCars++;
            Console.WriteLine();
            

            Car car2 = new Car()
            {
                Make = "Ford",
                Model = "Bronco",
                Year = 2022,
                EngineNoise = "vruuug",
                HonkNoise = "beep",
                IsDrivable = true
            };
            CarLot.numberOfCars = 2;
            Console.WriteLine($"The number of cars in carlot is {CarLot.numberOfCars}");
            CarLot.numberOfCars++;
            Console.WriteLine();

            Car car3 = new Car(2019, "Toyota", "Camry", "vrrrroom", "honk", true);
            CarLot.numberOfCars=3;
            Console.WriteLine($"The number of cars in carlot is {CarLot.numberOfCars}");
            CarLot.numberOfCars++;


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            

        }

    }
}
