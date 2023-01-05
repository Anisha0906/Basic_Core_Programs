using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramme
{
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Basic Core Program");
                 Console.WriteLine("Choose option\n 1.Flip a Coin Head and Tail\t 2.Select Value is Leap Year Or not ");
                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        //FLIP COIN
                        FlipCoinSimulation FlipCoin = new FlipCoinSimulation();
                        FlipCoin.CheckHeadTailPercentage();
                        break;
                case 2:
                    //CheckLeapYearOrNot
                    LeapYearOrNot LeapYearOrNot = new LeapYearOrNot();
                    LeapYearOrNot.LeapYear();
                    break;
                default:
                        Console.WriteLine("Invalid Selection.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }

