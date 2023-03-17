using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04_Exercise_Enhanced_IfStatements
{
    internal class Program
    {
        /// <summary>
        /// Enhanced if statements
        /// Date : 17 Mar 2023
        /// </summary>
        /// <param name="Jack"></param>
        static void Main(string[] args)
        {
            /* Normal if statement method
             * 
            Console.Write("Enter current temperature : ");
            string temperature = Console.ReadLine();
            int temperatureNum = int.Parse(temperature);
            string value;

            if(temperatureNum <= 15)
            {
                Console.WriteLine("It is too cold here");
            }
            else if(temperatureNum >= 16 && temperatureNum <= 28)
            {
                Console.WriteLine("It is ok");
            }
            else if(temperatureNum > 28)
            {
                Console.WriteLine("It is hot here");
            }
            */

            //Enhanced if statements
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            //takes input from console
            Console.Write("Enter the current temperature : ");
            inputValue = Console.ReadLine();

            //validate the input as valid input integer value
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if (validInteger)
            {   // condition ? if true : if false
                //if is valid integer then it will check for the conditions using nested tenary operator
                temperatureMessage = inputTemperature < 15 ?
                    //true
                    "It is too cold here" :
                    //false
                    (inputTemperature >= 16 && inputTemperature <= 28) ?
                    //true
                    "It is cold here" :
                    //false
                    inputTemperature > 28 ?
                    //true
                    "it is hot here" :
                    //false
                    "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                //in case if the input value is not a valid temperature
                Console.WriteLine("Not a valid Temperature");
            }

            Console.Read();
        }
    }
}





