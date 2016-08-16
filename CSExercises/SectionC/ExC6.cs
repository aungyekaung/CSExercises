using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            int tvNum, dvdNum, mp3Num;
            Console.WriteLine("Enter TV Amount:");
            tvNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DVD Amount:");
            dvdNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter MP3 Amount:");
            mp3Num = Convert.ToInt32(Console.ReadLine());

            Double Cost = CalculateTotalPrice(tvNum, dvdNum, mp3Num);

            Console.WriteLine("Your total cost is : {0}", Cost);


        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            Double totPriceA, totPriceB, totPrice;
            Double discount = 0;
            int tvPrice, dvdPrice, mp3Price;

            tvPrice = tvQty * 900;
            dvdPrice = dvdQty * 500;
            mp3Price = mp3Qty * 700;

            totPriceA = tvPrice + dvdPrice;

            totPriceB = totPriceA + mp3Qty;

            if (totPriceA > 5000 && totPriceA <= 10000)
            {
                discount = totPriceA * 0.1;
            }
            else
            {
                if (totPriceA > 10000)
                {
                    discount = totPriceA * 0.15;
                }
            }

            totPrice = totPriceB - discount;

            return totPrice;


        }
    }
}