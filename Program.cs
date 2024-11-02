namespace Gameoff24
{
    class Gameoff24
    {
        // function to quit game
       
        public static void Main(string[] args)
        {
             void QuitGame()
        {
            Thread.Sleep(2000);
            Console.WriteLine("GoodBye!\n");
            Environment.Exit(0);

        }   
        // funciton to reset and  clear 
            string ResetAndClear(string errorMessage, string switchinputtoreset)
            {
                Console.Clear();
                System.Console.WriteLine(errorMessage);
                Thread.Sleep(2000);
                switchinputtoreset="";
                return switchinputtoreset;
                
                
            }     
            // function to clear screen after the user is prompted to hit any key.
            void PromptedClearScreen()
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
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
                        QuitGame();
                        break;
                    default:
                        /*
                            create a function with the folowing parameters string to prompt user to select from the choices above, string to reset the switch statement, int for thread.sleep.
                        */
                        ResetAndClear("Please choose to either \n1) New game\n 2) Quit Game",titleMenuOption);
                        //titleMenuOption="";
                    break;
                }
            }
           

        }
    }
}