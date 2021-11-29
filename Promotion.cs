using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceCD=0, priceC=0, priceD =0;
           
            //without using try and catch
            int CountA = Convert.ToInt32(args[0]);
            int CountB = Convert.ToInt32(args[1]);
            int CountC = Convert.ToInt32(args[2]);
            int CountD = Convert.ToInt32(args[3]);
            

            Console.WriteLine("CountA ="+CountA);
            Console.WriteLine("CountB ="+CountB);
            Console.WriteLine("CountC ="+CountC);
            Console.WriteLine("CountD ="+CountD);

            //Calculation of promotions - plain discount without design pattern implementation
            
            int priceA = (CountA/3) *130 + (CountA%3) * 50;
            Console.WriteLine("CountAdiv3mul130 = "+(CountA/3)*130 + "    CountAmod3mul50 = "+(CountA%3)*50);
            
            int priceB = (CountB/2) * 45 + (CountB%2) * 30;
            Console.WriteLine("CountBdiv2mul45 = "+(CountB/2)*45 + "    CountBmod2mul30 = "+(CountB%2)*30);

            //Combo promotion goes here
            while (CountC>=1 && CountD>=1)
            {
               --CountC;
               --CountD;
               priceCD = priceCD + 30;
               Console.WriteLine("priceCDfor30 = "+ priceCD);
            }    
            
            //combo promotion not applicable, so take the unit price
            if (CountC>0)
            {
                priceC = CountC*20;
                Console.WriteLine("priceC = "+ priceC);
            }
            
            if (CountD>0)
            {
                priceD = CountD*15;
                Console.WriteLine("priceD = "+ priceD);
            }
                     
            //Calculate discounted price
            int totalPrice = priceA + priceB + priceC + priceD + priceCD;

            Console.WriteLine("Total price after discount if applicable = "+ totalPrice);
           }
       }
  }
