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
                        //System.Console.WriteLine("New game started\n");
                        Console.WriteLine("The year is 1849, You have set out to find information on the disappearance of a civilization known as Shattered Harmony Refuge.\n The first thing that you are tasked to do is find a potential location of this civilization. Luckily, you have texts that may give you location.\n You may also look at maps to deduce the location, without the books, the location may most likely be inacurate." );
                        // switch to prompt player for first course of action
                        string PlayerInitChoice="";
                        while(PlayerInitChoice=="")
                        {
                            Console.WriteLine("Would you like to: 1) Read historical books \n 2) Look at maps");
                            PlayerInitChoice=Console.ReadLine();
                            switch(PlayerInitChoice.ToLower())
                            {
                                // read books
                                case "1":
                                    System.Console.WriteLine();
                                break;
                                // look at maps
                                case "2":
                                    System.Console.WriteLine();
                                break;
                                case "q":
                                    QuitGame();
                                break;
                                default:
                                    ResetAndClear("Please choose from \n 1) Read through historical texts \n 2) Look at maps\n",PlayerInitChoice);
                                break;
                            }
                        }
                        


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