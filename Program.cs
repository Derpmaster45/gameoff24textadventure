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
                        Console.WriteLine("The year is 1849, You have set out to find information on the disappearance of a civilization known as Shattered Harmony Refuge.\n The first thing that you are tasked to do is find a potential location of this civilization. Luckily, you have texts that may give you location.\n You may also look at maps to deduce the location, without the books, the location may most likely be inacurate.\n" );
                        // switch to prompt player for first course of action
                        string PlayerInitChoice="";
                        bool bHasReadBooks=false;
                        int BooksRead=0;
                        while(PlayerInitChoice=="")
                        {
                            Console.WriteLine("Would you like to: \n1) Read historical books \n 2) Look at maps");
                            PlayerInitChoice=Console.ReadLine();
                            switch(PlayerInitChoice.ToLower())
                            {
                                // read books
                                case "1":
                                case "read books":
                                case "read historical books":
                                    Console.WriteLine("You decide to read historical books to see if you can pinpoint a region for the shattered Harmony Refuge\n");
                                    string BookChoice="";
                                    while(BookChoice=="")
                                    {
                                        Console.WriteLine("Which book would you like to take from the bookself\n1) History of HydroElectricity\n2) The parable of stanley \n3) Writings of john\nQ if you would like to quit\n");
                                        BookChoice=Console.ReadLine();
                                        switch(BookChoice.ToLower())
                                        {
                                            // history of hydroelectricity book
                                            case"1":
                                            case"history of hydroelectricty":
                                            System.Console.WriteLine("You grab a book called 'History of HydroElectricty' off of the shelf\n ");
                                            if(BooksRead==2)
                                            {
                                                // insert story code
                                                bHasReadBooks=true;
                                                PlayerInitChoice="";
                                            } else
                                            {
                                                BooksRead++;
                                                BookChoice="";
                                            }
                                            break;
                                            //choose your own adventure book
                                            case"2":
                                            case"The parable of stanley":
                                            System.Console.WriteLine("You decide to grab a book called 'The parable of stanley' from the bookself\n  you spend hours getting every ending ");
                                            Thread.Sleep(3000);
                                            ResetAndClear("The end is never the end is never the end is never\n",BookChoice);
                                            BookChoice="";
                                            break;
                                            // writings of a historian book
                                            case"3":
                                            case" Writings of john":
                                            System.Console.WriteLine("you decide read the book from john talking about the inhabitance of the region.\n You learn that the inhabitance was 100 miles from the coast of an island.\n The Inhabitance were farmers and created aquaducts.  The book does not theorize about the dissappearance of the people or culture.\n");
                                            if(BooksRead==2)
                                            {
                                                bHasReadBooks=true;
                                                PlayerInitChoice="";
                                            } else
                                            {
                                                BooksRead++;
                                                // inform users that they may not have enough info to move foreward.
                                                string MoveForward="";
                                                while(MoveForward=="")
                                                {
                                                     System.Console.WriteLine("Do you want to \n1) read more books\n2) look at maps ");
                                                     MoveForward=Console.ReadLine();
                                                     switch (MoveForward.ToLower())
                                                     {
                                                        case"1":
                                                        case"read more books":
                                                        System.Console.WriteLine("You decide to read more books\n");
                                                        BookChoice="";
                                                        break;
                                                        case "2":
                                                        case "look at maps":
                                                        System.Console.WriteLine("You decide to look at maps\n");
                                                        PlayerInitChoice="";
                                                        break;
                                                        default:
                                                        ResetAndClear("Please choose from the 2 above options \n1) read more books \n2) look at maps\n",MoveForward);
                                                        break;
                                                     }
                                                }
                                                //BookChoice="";
                                            }
                                            break;
                                            // if player wants to quit
                                            case"q":
                                            QuitGame();
                                            break;
                                            // what the program should do if none of those optiens are selected.
                                            default:
                                            ResetAndClear("Please select from the 3 book choices above\n", BookChoice);
                                            BookChoice="";
                                            break;

                                        }
                                    }
                                    PromptedClearScreen();
                                break;
                                // look at maps
                                case "2":
                                    System.Console.WriteLine("You decide to look at maps of the kingdom\n");
                                    if(bHasReadBooks==true)
                                    {
                                        // story goes here.
                                        System.Console.WriteLine(bHasReadBooks);
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("You decide to look at maps\n Not knowing the general location of the civilization\n You decide to look at some of the books you have to try and find the answer.\n");
                                        PlayerInitChoice="";
                                    }
                                    PromptedClearScreen();
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