using System;

namespace new_project
{
    class Program
    {
		static void Switchcases(){
			
			Console.WriteLine("Enter which question you want to run (1 to 16):");
            int ques = Convert.ToInt32(Console.ReadLine());

            switch (ques)
            {
                case 1:
                    CalculateHarryAge Obj1 = new CalculateHarryAge();
                    Obj1.AgeCalculate();
                    break;

                case 2:
                    AveragePercentage Obj2 = new AveragePercentage();
                    Obj2.Average();
                    break;
					
				case 3:
					KmToMiles obj3 = new KmToMiles();
					obj3.ConvertKmtoMiles();
					break;
				
				case 4:
					ProfitCalculator obj4 = new ProfitCalculator();
					obj4.CalculateProfit();
					break;
					
				case 5:
				    PenDistribution obj5 = new PenDistribution();
					obj5.Distribution();
					break;
				
				case 6:
					 DiscountCalculator obj6 = new DiscountCalculator();
					 obj6.CalculateFee();
					 break;
				
				case 7:
					 VolumeCalculator obj7 = new VolumeCalculator();
                     obj7.ComputeVolume();
					 break;
					
				case 8:
					KmToMiles2 obj8 = new KmToMiles2();
					obj8.ConvertKmtoMiles2();
					break;
				
				case 9:
					DiscountCalculator2 obj9 = new DiscountCalculator2();
					obj9.CalculateFee();
					break;
				
				case 10:
					HeightConverter obj10 = new HeightConverter();
					obj10.ConvertHeight();
					break;
				case 11:
					BasicCalculator obj11 = new BasicCalculator();
					obj11.PerformOperations();
					break;
				case 12:
					TriangleAreaCalculator obj12 = new TriangleAreaCalculator();
					obj12.CalculateArea();
					break;
				case 13:
					FindSide obj13 = new FindSide();
					obj13.CalSide();
					break;
				case 14:
					YardAndMiles obj14 = new YardAndMiles();
					obj14.ConvertYardfromCm();
					break;
				case 15:
					CalcTotalPrice obj15 = new CalcTotalPrice();
					obj15.CalPrice();
					break;
				case 16:
				 HandshakeCalculator obj16 = new HandshakeCalculator();
				 obj16.CalculateHandshakes();
				 break;
                default:
                    Console.WriteLine("Invalid question number. Please select between 1 and 16.");
                    break;
            }
		}
        static void Main(string[] args)
        {
            Switchcases();
        }
    }
}
