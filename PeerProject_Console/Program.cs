using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerProject_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // PeerProject
            // 
            // The main goal of this will be to create a Mad-Libs style console app.
            // I will add the main notes here, about how we will go about this but at the end of this Replit there will be also comment notes about what goes in this file.
            // Building a Mad-Libs generator should be pretty straight forward. The methods and some of the classes will be familiar.
            // The actual interface will be based upon getting a series of strings from the user and pluging that into an already set long string with spaces to plug in the variable, supplied by the user.
            // Ideally I would like the menu to be simple, where the user selects a number off of a list. Something like:
            // 1. Try a Mad-Lib that asks for two words.
            // 2. Try a Mad-Lib that asks for three words.
            // 3. Try a Mad-Lib that asks for four words.
            // And so on.
            // This frees us up a little for bugs and time constraints as once we have the first Mad-Lib working, along with the menu working and such, we have effectively completed the requirements and can use the existing Mad-Lib code as a roadmap to add more.
            // Since I think this type of console app will be light on the use of differing methods and classes, I might as a side project research two additional, optional, inclusions: A sleep timer so that the Mad-Lib, if it is long enough, can be displayed one sentance at a time and a method to return the user to the main menu, rather than having to exit the console to play again (Note: nevermind, the while loops solves this).
            // Initially I created the repository files incase we wanted to use methods stored in a repository as with the Streaming Constent project, but those may not actually be needed. It is likely we can constrain our code to the ProgramUI.cs and Program.cs files. What are your thoughts?




            // --- To build in this Program.cs specifically ----
            //
            // In this program, 'Program.cs', what will be needed will be similar to the Streaming Content's Program.cs if you want to look over that for reference. 
            // So far we know we will need to call upon a class, or new-up a class created elsewhere, likely called ProgramUI as it was in the Streaming Content project.
            // We will also need call upon the Run Method to run the methods we will place in the 'ProgramUI.cs' class list. Roughly it will look like this:

            ProgramUI ui = new ProgramUI();
            // sets a new instance of the ProgramUI class as 'ui'

            ui.Run();
            // Starts the Run Method in the Class ProgramUI

            // Console.ReadKey(); // Removed as redunant also seemed to be the bug needing users to have to hit 'any key' twice in order to exit after entering the number corresponding to the exit command. Commented out rather than removed for future reference.
            // The Run method will load our Menu, also found in 'ProgramUI.cs' and any thing else we have inside Run so we need to give the user time to chose an option.
        }
    }
}
