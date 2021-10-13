using System;
using PeerProject_Repo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PeerProject_Console
{
    public class ProgramUI
    {


        // The first thing we will likely work on is the ProgramUI class as that will house our other methods we would want to call up when the program is initiated. So the first step in that is the Run Method
        // In the Run Method we will place at least our RunMenu Method (below) but we may want to add an addition method or more to fire at launch. Plus we want the user to be able to interact with this method but the actual menu we create that will fire from 'RunMenu' should not be alterable by the user. Therefore this Run Method will be set to public but the actual menu in RunMenu will be set to private.
        public void Run()
        {
            RunMenu();
        }
        // Now the first biggie, the RunMenu method.
        // Other than content I cannot think of a reason to make this in a different way than the one built in Streaming Content.
        private void RunMenu()
        {
            // So similarly it will be nested in a while conditional. The while loop will be set similarly to a bool very much like the one we used in Streaming Content:
            // bool continueToRun = true;
            // while (continueToRun)...  
            // Also Console.Clear each time we call this, so this isn't a long ongoing thing in our console.
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to your very own Mad-Libs game!\n\n" +
                    "From this menu you can choose a Mad-Libs based on how many words you would like to use.\n\n" +
                    "Enter the number representing the number of Mad-Lib words you would like to play with:\n\n" +
                    "1. Try a Mad-Lib that asks for two words.\n\n" +
                    "2. Try a Mad-Lib that asks for three words.\n\n" +
                    "3. Try a Mad-Lib that asks for four words.\n\n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        MadLibOne();
                        break;
                    case "2":
                        MadLibTwo();
                        break;
                    case "3":
                        MadLibThree();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 4.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void  Pause()
            // Really wanted this to work and glad it did. In order for this to be implemented the using statements/references will need to include System.Threading and System.Threading.Tasks. VS studio did this for me automatically witht he Cntl '.' shortcut.
        {
            Thread.Sleep(2000);
        }
        public void MadLibOne()
        {
            
            Console.Clear();
            Console.WriteLine("Please type out a mood:");
            string mood = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please type out a body part:");
            string bodyPart = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("C:> If you're "+ mood.ToLower() + " and you know it, Syntax error!\n\n" + 
                "Syntax error\n\n");
            Pause();
            Console.WriteLine("C:> If you're "+ mood.ToLower() + " and you know it, Syntax error!\n\n" +
                "Syntax error\n\n");
            Pause();
            Console.WriteLine("C:> If you're " + mood.ToLower() + " and you know it, then your " + bodyPart.ToLower() + " will surely show it. If you're " + mood.ToLower() + " and you know it, Syntax error!\n\n" +
                "Syntax error\n\n");
            Pause();
            Console.WriteLine("Please press any key to return...");
            Console.ReadKey();
        }
        public void MadLibTwo()
        {
            Console.Clear();
            Console.WriteLine("Please enter country:");
            string country = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a city:");
            string city = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a city street:");
            string cityStreet = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The country is " + country.ToLower() + ",\n\n");
            Pause();
            Console.WriteLine("The city is " + city.ToLower() + ",\n\n");
            Pause();
            Console.WriteLine("The city street is " + cityStreet.ToLower() + ",\n\n");
            Pause();
            Console.WriteLine("Please press any key to return...");
            Console.ReadKey();
        }
        public void MadLibThree()
        {
            
            Console.Clear();
            Console.WriteLine("Please type out a color:");
            string color = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please type out a plural noun:");
            string pluralNoun = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please type out a noun:");
            string noun = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please type out a adjective:");
            string adj = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Roses are " + color.ToLower() + ",\n\n");
            Pause();
            Console.WriteLine(pluralNoun + " are blue,\n\n");
            Pause();
            Console.WriteLine(noun + " is " + adj.ToLower() + ", \n\n");
            Pause();
            Console.WriteLine("and so are you.\n\n");
            Pause();
            Console.WriteLine("Please press any key to return...");
            Console.ReadKey();
        }
        // Then a lot of fun with what is displayed through Console.WriteLine. Roughly this is what the user sees:
        // 1. Try a Mad-Lib that asks for two words.
        // 2. Try a Mad-Lib that asks for three words.
        // 3. Try a Mad-Lib that asks for four words.
        // And so on.
        // (last number). Exit
        // A Console.ReadLine will catch the user input as a string, so important to remember to evaluate each case in the switch case as a string.
        // Then we build our switch case conditional. At first we can do cases for 1, 2, or 3 and then the default. If we have time to further develop Mad-Lib number 4, or 5, or 6 we can add them in as we go.
        // The switch case for chosing number 1 would roughly include:
        // case "1":
        //    MadLibOne();
        //    break;
        // ...
        // The Exit would change the bool used in the while loop to false via:
        // case (last number):
        //    continueToRun = false;
        //    break;
        // ...
        // And the break would catch anything not a valid entry, such as a number we don't use, or typing a word. We would need to let the user know what the error was through a Console.WriteLine.
        // After this we build our Mad-Lib methods.
        // For this I am going to hash out how I would build the MadLibOne() method from above. Once we code this and get it to work it should be easy to duplicate or use as a road map to make others.
        // Because I think it would be a little funny to have this Mad-Lib emulate a meme of an old error found in the DOS version of command prompt, what I would want to do is capture two variables that are strings and then display them in the format of the meme (this is about as old as the internet). To do this I would:
        // After the user picks '1' we use Console.WriteLine to ask:
        // "Please type out a mood:"
        // The method then captures this as a string called mood
        // Then the screen is cleared (Console.Clear) and the user is prompted again via Console.WriteLine:
        // "Please type out a body part:"
        // The method then captures this in a second string called bodyPart
        // The screen is again cleared and the method returns the completed Mad-Lib as a string with concatenation
        // Displayed on the screen would be:
        // "If you're (mood) and you know it, syntax error!"
        // "Syntax error"
        // "If you're (mood) and you know it, syntax error!"
        // "Syntax error"
        // "If you're (mood) and you know it, then your (bodyPart) will surely show it. If you're (mood) and you know it, syntax error!"
        // "Syntax error"
        // Of course the joke is best played if the string captured to the variable 'mood' is 'happy' and the one caught by 'bodyPart' is face, but it still functions.
        // I want to look up timers and sleeps so that the spaces between the lines take like a half second to display the next line.
        // Also after playing the Mad-Lib we would want a Console.ReadKey with a prmopt to tell the user to hit any key to exit, or if I can find it and code it, it would be hit any key to return to the main menu.
        // For extra exercize, and if we think we had time, we could try building some loop to at least make sure the user inputs characters and not numbers. If the user entered a number it wouldn't break the code, I don't think, as it would just be a number captured to a string, but its less fun if someone enters in '42' for their mood.
    }
}
