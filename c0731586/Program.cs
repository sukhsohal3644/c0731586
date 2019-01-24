using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practise_3

{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");

            }
            else { Console.WriteLine("Promoted to Level 2"); }
        }





        public int CalculateRating()
        {

            return 0;
        }


    }




    class Program
    {
        static void Main(string[] args)
        {
            //var dog_and_cat = new car();
            //var bowling = new car();
            //Console.WriteLine("How many cars: {0}", Vehicle.howManyCars);
            //Console.ReadLine();   

            //Book myBook = new Book();
            //myBook.SetTitle ("A Seperate Peace");
            //Console.WriteLine(myBook.GetTitle());
            //Console.ReadLine();
        }
    }

    class Vehicle
    {

        public static int howManyCars = 0;
        public String color = "Blue";
    }

    class car : Vehicle
    {
        public String Color = "Red";
        public car()
        {
            Vehicle.howManyCars++;
            Console.WriteLine("my color is " + color);
            Console.ReadLine();

        }
    }

    class BookCollection

    {

    }
    class Book : BookCollection

    {
        private String Title;
        public void SetTitle(string aTitle) { this.Title = aTitle; }
        public String GetTitle() { return this.Title; }
    }
}
