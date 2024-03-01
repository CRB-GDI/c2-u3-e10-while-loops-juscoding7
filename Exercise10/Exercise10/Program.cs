namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Printing Choicees
            Console.WriteLine("************");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("************");

            Console.WriteLine("Pick one of the choices above");
            int numberpicked = int.Parse(Console.ReadLine()); 

            if (numberpicked == 1)
            {
                Console.WriteLine(); 
                Console.WriteLine("Creating New Game ...");
            }

            if (numberpicked == 2)
            {
                Console.WriteLine(); 
                Console.WriteLine("Loading game ...");
            }
            if (numberpicked == 3)
            {
                Console.WriteLine(); 
                Console.WriteLine("Showing Options ...");
            }
            if (numberpicked == 4)
            {
                Console.WriteLine(); 
                Console.WriteLine("Quitting game ... bye ;(");
                Console.WriteLine("Press Alt + F4");
            }
            //Invalid Options
            while (numberpicked < 1 || numberpicked > 4)
            {
                Console.WriteLine();
                Console.WriteLine("That is not a valid option goofball");

                //Restating they need to pick a valid option
                Console.WriteLine("************");
                Console.WriteLine("Menu");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("************");

                Console.WriteLine("Pick one of the choices ABOVE");
                numberpicked = int.Parse(Console.ReadLine());
            }

            //print choice
            if (numberpicked == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Creating New Game ...");
            }

            if (numberpicked == 2)
            {
                Console.WriteLine(); 
                Console.WriteLine("Loading game ...");
            }
            if (numberpicked == 3)
            {
                Console.WriteLine(); 
                Console.WriteLine("Showing Options ...");
            }
            if (numberpicked == 4)
            {
                Console.WriteLine(); 
                Console.WriteLine("Quitting game ... bye ;(");
                Console.WriteLine("Press Alt + F4");
            }


        }
    }
}