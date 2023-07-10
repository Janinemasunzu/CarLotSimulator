using System;
using System.Reflection;

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

            CarLot myCarlot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var BettyCar = new Car();
            BettyCar.Make = "Hyundai";
            BettyCar.Make = "Hyundai";
            BettyCar.Model = "Tuscon";
            BettyCar.Year = 2022;
            BettyCar.EngineNoise = "vroom";
            BettyCar.HonkNoise = "beep";
            BettyCar.IsDrivable = true;

            
            myCarlot.ListOfCars.Add(BettyCar);

            CarLot.numberOfCars++; 
            Console.WriteLine($"There are {CarLot.numberOfCars} cars on my carlot");
            Console.WriteLine();

            var JanineCar = new Car()
            {
                Make = "Ford",
                Model = "Bronco",
                Year = 2023,
                EngineNoise = "vruuug",
                HonkNoise = "beep",
                IsDrivable = true

            };

            myCarlot.ListOfCars.Add(JanineCar);

            CarLot.numberOfCars++;
            Console.WriteLine($"There are {CarLot.numberOfCars} cars on my carlot");
            Console.WriteLine();    

            var JesseCar = new Car(2019, "Toyota", "Camry", "vrrrroom", "honk", true);

            myCarlot.ListOfCars.Add(JesseCar);

            CarLot.numberOfCars++;
            Console.WriteLine($"There are {CarLot.numberOfCars} cars on my carlot");
            Console.WriteLine();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var item in myCarlot.ListOfCars)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.IsDrivable);
                item.MakeEngineNoise(item.EngineNoise);
                item.MakeHonkNoise(item.HonkNoise);
                Console.WriteLine();

            }


        }

    }
}
