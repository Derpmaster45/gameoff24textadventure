namespace Gameoff24
{
    class Gameoff24
    {
        // function to display menu 
        
        
        public static void Main(string[] args)
        {
            // display title menu
            string titleMenuOption="";
            while (titleMenuOption=="")
            {
                Console.WriteLine("Gameoff 24\n 1) New Game\n 2) Quit");
                titleMenuOption=Console.ReadLine();
                switch (titleMenuOption.ToLower())
                {
                    case "1":
                    case"new game":
                        System.Console.WriteLine("New game started\n");
                    break;
                    case "2":
                    case "quit game":
                    // creqte function to quit game
                        //QuitGame();
                        break;
                    default:
                        /*
                            create a function with the folowing parameters string to prompt user to select from the choices above, string to reset the switch statement, int for thread.sleep.
                        */
                    break;
                }
            }
           

        }
    }
}