

namespace CalcylatorV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message with the possibility to add fetures like coulors or sounds
            // Highly cousomizeble to its liking
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("          ========================================================================================\n");

            Console.WriteLine("                            Welcome to the ULTIMATE DELUXE SUPER HYPER Calcylator \n                   ");

            Console.WriteLine("          ========================================================================================\n");

            // Adds a readkey to let the use choose when to continue

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*Use at own risk*\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press anny key to continue...");
            Console.ReadKey();






            //Create a list to save the values and awnsers from the last calcylations.

            List<string> calcylatorList = new List<string>();

            //Contains string array for menu selections
            string[] menuOptions = new string[] { "  Kalkylator", "  Lista", "  Avsluta" };


            //Gives menu selection the stariting value of 0
            //creates a true/false that is used later to "play again" the calkylator
            int menuSelect = 0;
            bool jump = true;


            // This is the menu selektion loop itself 
            while (jump)
            {

                // Clears the screen
                Console.Clear();
                // Hides the cursor
                Console.CursorVisible = false;

                // Meny headline
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("          ========================================================================================\n");

                Console.WriteLine("                            Welcome to the ULTIMATE DELUXE SUPER HYPER Calcylator \n                   ");

                Console.WriteLine("          ========================================================================================\n\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Make Your Choise By Using Your Arrow Keys\n   ");
                Console.ForegroundColor = ConsoleColor.White;
                // Builds menu selections for arrow keys with if statement
                if (menuSelect == 0)
                {
                    Console.WriteLine(menuOptions[0] + "   <---");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                }
                else if (menuSelect == 1)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1] + "        <---");
                    Console.WriteLine(menuOptions[2]);
                }
                else if (menuSelect == 2)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2] + "      <---");
                }
                // Catch user choise with arrow keys
                var keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                {
                    menuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                {
                    menuSelect--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (menuSelect)
                    {
                        case 0:
                            //trycatch so the program dont crash if user imputs incorrect carracters(gives a error message)
                            try
                            {
                                FirstChoise(calcylatorList);
                            }
                            catch (Exception e)
                            {

                                Console.WriteLine(e);
                            }


                            //Asks the user if he/her wants to go back to the menu
                            Console.WriteLine("Vill du köra igen?");
                            Console.WriteLine("Y/N");


                            //If user presses the key "N" on keyboard, it will close the program

                            if (Console.ReadKey(true).Key == ConsoleKey.N)
                            {
                                jump = false;
                            }

                            break;
                        //Shows the previous calcylations and lists them
                        case 1:

                            //Referes to the case "SecondChoise"
                            SecondChoise(calcylatorList);

                            //Asks the user if he/her wants to go back to the menu
                            Console.WriteLine("Vill du köra igen?");
                            Console.WriteLine("Y/N");


                            //If user presses the key "N" on keyboard, it will close the program

                            if (Console.ReadKey(true).Key == ConsoleKey.N)
                            {
                                jump = false;
                            }
                            break;
                        //quit program by exiting the loop
                        case 2:
                            ThirdChoise();
                            jump = false;
                            break;
                    }
                }
            }

            //choise 1 that is the calcylator itself
            static void FirstChoise(List<string> calcylatorList)

            {

                int result;
                string save;


                //its possible to use Int.Parse instaid of Convert.toInt32 and it will have the same effect
                //take the users numbers and turning them to int
                Console.Clear();


                //takes the users input from the CW questions and putting them into int/strings
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter symbol(/,+,-,*): ");
                string symbol = Console.ReadLine();

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                //int finalResult = Console.WriteLine(num1 + symbol + num2).ToString(); 

                // string stringNum1 = num1;



                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;                                       // Calculation
                        save = num1 + " " + "+" + " " + num2 + " = " + result;      // The saveing text
                        calcylatorList.Add(save);                                   // Add i to list
                        Console.WriteLine("Awnser:" + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        save = num1 + " " + "-" + " " + num2 + " = " + result;
                        calcylatorList.Add(save);
                        Console.WriteLine("Awnser:" + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        save = num1 + " " + "*" + " " + num2 + " = " + result;
                        calcylatorList.Add(save);
                        Console.WriteLine("Awnser:" + result);
                        break;

                    case "/":
                        // if the user whats to use divition it has to check so the user dont try devide by 0(infinite)
                        //therefore using a if statement and checking if num1 or num2 is equal to zero. Otherwise continue as usual

                        if (num1 == 0 || num2 == 0)
                        {
                            Console.WriteLine("\nOgiltig inmatning!");
                            break;
                        }
                        else
                        {
                            result = num1 / num2;
                            save = num1 + " " + "/" + " " + num2 + " = " + result;
                            calcylatorList.Add(save);
                            Console.WriteLine("Awnser:" + result);
                            break;

                        }

                    //if the user is a donkey and types something wrong ===>
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }


                Console.ReadKey();
            }
            //the list that lets the program use the list while its inside the switch caste(second choise)
            static void SecondChoise(List<string> calcylatorList)

            {
                Console.Clear();
                foreach (var item in calcylatorList)
                {
                    Console.WriteLine(item);
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
            // the code 4 third choise
            static void ThirdChoise()

            {
                Console.Clear();
                Console.WriteLine("Have a nice day! Bye...");
                Console.ReadKey();

            }





        }

        //  Pseudo kod       
        // Välkomnande meddelande                                                           ¤Done
        // En lista för att spara historik för räkningar                                    ¤Done
        //Meny att välja vilket alternativ                                                  ¤Done
        // Användaren matar in tal och matematiska operation                                ¤Done
        //OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!   ¤Done
        // Ifall användaren skulle dela 0 med 0 visa Ogiltig inmatning!                     ¤Done
        // Lägga resultat till listan                                                       ¤Done
        //Visa resultat                                                                     ¤Done
        //Fråga användaren om den vill visa tidigare resultat.                              ¤Done
        //Visa tidigare resultat                                                            ¤Done
        //Fråga användaren om den vill avsluta eller fortsätta.                             ¤Done
        //fixa vissuelt pogrammet så de blir fint                                           ¤Done


        //===================================Reflektioner utöver kod komentarer====================================================

        //Det finns alltid saker man kan förbättra i kod och denna är inget undantag
        //saker som jag skulle kunna ha valt att göra isället för att förbättra pogrammet kunde vara; Ändra meny och meny valen så att de blev tydligare/bättre
        //låta användaren räkna ut mer avanserade pogram i exempelvis en egen funktion eller metod,byta ut int till doubble för att få decimaltal, lägga till onödiga funktioner som klocka, bakgrundsmusik
        //nya fräna shiftande färger eller en meningslös knapp bara för att man kan.
        //Jag vill dock säga att jag lärde mig väldigt mycket under processen av denna miniräknare då jag behövde utnytja alla delar som jag lärt mig
        //under kursen till ett konkret projekt!
        // Sist men inte minst vill jag tacka dig för att du förklarat, lyssnat och anpassat lektionerna utifrån oss och våra behov och tycken.

        //Har du feedback får du gärna skicka de också!

















        ////Reed the list(one of the menu options
        //foreach (string tal in calcylatorList)
        //{
        //    Console.WriteLine(tal);
        //    Console.WriteLine();
        //}
    }
}