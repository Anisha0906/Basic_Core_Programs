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
                 Console.WriteLine("Choose option\n 1.Flip a Coin Head and Tail\t 2.Select Value is Leap Year Or not\t 3.Select Power of 2 Number\t\n 4.Harmonic Number\t 5.Select Factors of number\t 6.Find Quotient and Remainder ");
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
                case 3:
                    PowerOf2 CalculatePower = new PowerOf2();
                    CalculatePower.CalculationOfPower();
                    break;
                case 4:
                    HarmonicNumber CalculateHarmonicNumber = new HarmonicNumber();
                    CalculateHarmonicNumber.CalcHarmonicSeries();
                    break;
                case 5:
                    PrimeFactorization PrimeFactor = new PrimeFactorization();
                    PrimeFactor.CalcSFactorialSeries();
                    break;
                case 6:
                    QusRemainders QuesRem = new QusRemainders();
                    QuesRem.QuotientRemainder();
                    break;
                default:
                        Console.WriteLine("Invalid Selection.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }

