using System;

namespace _2nd_part
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the distace to the destination friends want to go:");
            double distace = Convert.ToDouble(Console.ReadLine());  //20
            Console.WriteLine("Enter the walking speed :");
            double walking_speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the bike speed :");//5
            double bike_speed = Convert.ToDouble(Console.ReadLine());//20
            Console.WriteLine("Enter the number of friends:");
            int friends = Convert.ToInt32(Console.ReadLine());//3


            double trip_time = 0;
            double meet_time = 0;
            double bike_time = 0;
            double distance_left = 0;
            double backtime = 0;
            int trips = 1;


            for (int i = friends; i >= 2; i--)
            {
                bike_time = distace / bike_speed;
                distance_left = distace - walking_speed * bike_time * trips;
                meet_time = distance_left / (bike_speed + (distance_left / walking_speed));               
                trip_time += bike_time + 2*meet_time;
                trips++;
                distance_left = 0;
                meet_time = 0;
                
            }
            Console.WriteLine(trip_time);

        }
    }
}
