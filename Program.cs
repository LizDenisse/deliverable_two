using System;

namespace unit1homework2
{
    class Program
    {


        static void Main()

        {
            Console.WriteLine("Hello User, What are you in the mood for?");
            Console.WriteLine("Here are your options:");
            Console.WriteLine(" 1) Action");
            Console.WriteLine(" 2) Chilling");
            Console.WriteLine(" 3) Danger");
            Console.WriteLine(" 4) Food");
            string activity = Console.ReadLine();
            Console.WriteLine("How Many People? ");
            int people = Convert.ToInt32(Console.ReadLine());


            if (people == 0) // Sneakers

            {
                switch (activity)
                {

                    case "Action": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should go with your sneakers "); break;
                    case "action": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should go with your sneakers "); break;
                    case "1": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should go with your sneakers "); break;
                    case "Chilling": Console.WriteLine("Ok, if you are in the mood for chilling; you should go Hiking and you should take your sneakers"); break;
                    case "chilling": Console.WriteLine("You should go Hiking and you should take your sneakers"); break;
                    case "2": Console.WriteLine("You should go Hiking and you should take your sneakers"); break;
                    case "Danger": Console.WriteLine("You are Crazy! You should go Skydiving and you should take your sneakers"); break;
                    case "danger": Console.WriteLine("You are Crazy! You should go Skydiving and you should take your sneakers"); break;
                    case "3": Console.WriteLine("You are Crazy! You should go Skydiving and you should take your sneakers"); break;
                    case "Food": Console.WriteLine("If you are Hungry you should go to Taco Bell and you should take your sneakers"); break;
                    case "food": Console.WriteLine("If you are Hungry you should go to Taco Bell and you should take your sneakers"); break;
                    case "4": Console.WriteLine(" If you are Hungry you should go to Taco Bell and you should take your sneakers"); break;
                    default: Console.WriteLine("Invalid Entry,"); break;

                }
            }


            if (people > 1 && people <= 5)  //a Sedan
            {
                switch (activity)
                {

                    case "Action": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should travel on a Sedan "); break;
                    case "action": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should travel on a Sedan "); break;
                    case "1": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should travel on a Sedan "); break;
                    case "Chilling": Console.WriteLine("You should go Hiking and you should travel on a Sedan"); break;
                    case "chilling": Console.WriteLine("You should go Hiking and you should travel on a Sedan"); break;
                    case "2": Console.WriteLine("You should go Hiking and you should travel on a Sedan"); break;
                    case "Danger": Console.WriteLine("You are Crazy! You should go Skydiving and you should travel on a Sedan"); break;
                    case "danger": Console.WriteLine("You are Crazy! You should go Skydiving and you should travel on a Sedan"); break;
                    case "3": Console.WriteLine("You are Crazy! You should go Skydiving and you should travel on a Sedan"); break;
                    case "Food": Console.WriteLine("If you are Hungry you should  go to Taco Bell and you should travel on a Sedan"); break;
                    case "food": Console.WriteLine(" If you are Hungry you should go to Taco Belland you should travel on a Sedan"); break;
                    case "4": Console.WriteLine(" If you are Hungry you should go to Taco Bell and you should travel on a Sedan"); break;
                    default: Console.WriteLine("Invalid Entry"); break;

                }
            }

            if (people > 5 && people <= 10) //a Volkswagen bus
            {
                switch (activity)
                {

                    case "Action": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should travel on a volkswagen bus "); break;
                    case "action": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should travel on a volkswagen bus "); break;
                    case "1": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should travel on a volkswagen bus "); break;
                    case "Chilling": Console.WriteLine("You should go Hiking and you should travel on a volkswagen bus"); break;
                    case "chilling": Console.WriteLine("You should go Hiking and you should travel on a volkswagen bus"); break;
                    case "2": Console.WriteLine("You should go Hiking and you should travel on a volkswagen bus"); break;
                    case "Danger": Console.WriteLine("You are Crazy! You should go Skydiving and you should travel on a volkswagen bus"); break;
                    case "danger": Console.WriteLine("You are Crazy! You should go Skydiving and you should travel on a volkswagen bus"); break;
                    case "3": Console.WriteLine("You are Crazy! You should go Skydiving and you should travel on a volkswagen bus"); break;
                    case "Food": Console.WriteLine(" If you are Hungry you should go to Taco Bell and you should travel on a volkswagen bus"); break;
                    case "food": Console.WriteLine("If you are Hungry you should go to Taco Bel and you should travel on a volkswagen bus"); break;
                    case "4": Console.WriteLine(" If you are Hungry you should go to Taco Bell and you should travel on a volkswagen bus"); break;
                    default: Console.WriteLine("Invalid Entry"); break;

                }
            }

            if (people > 10) //an Airplane
            {
                switch (activity)
                {

                    case "Action": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should travel on an airplane "); break;
                    case "action": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should travel on an airplane "); break;
                    case "1": Console.WriteLine("Okay, if you are in the mood for Action, then you should go Stock car racing and you should travel on an airplane "); break;
                    case "Chilling": Console.WriteLine("You should go Hiking and you should travel on an airplane"); break;
                    case "chilling": Console.WriteLine("You should go Hiking and you should travel on an airplane"); break;
                    case "2": Console.WriteLine("You should go Hiking and you should travel on an airplane"); break;
                    case "Danger": Console.WriteLine("You are Crazy! You should Skydiving  and you should travel on an airplane"); break;
                    case "danger": Console.WriteLine("You are Crazy! You should Skydiving and you should travel on an airplane"); break;
                    case "3": Console.WriteLine("You are Crazy! You should Skydiving and you should travel on an airplane"); break;
                    case "Food": Console.WriteLine("If you are Hungry you should go to Taco Bell and you should travel on an airplane"); break;
                    case "food": Console.WriteLine(" If you are Hungry you should go to Taco Bell and you should travel on an airplane"); break;
                    case "4": Console.WriteLine("If you are Hungry you should go to Taco Bell and you should travel on an airplane"); break;
                    default: Console.WriteLine("Invalid Entry"); break;

                }
            }


            Console.WriteLine("Good Bye");

        }

    }

}
