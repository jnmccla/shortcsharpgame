using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainLibrary;
namespace PlayingWithCSharp
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Welcome.";
            Console.WriteLine("Welcome.");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
            library.say("W", 300);
            library.say("h", 300);
            library.say("e", 300);
            library.say("r", 300);
            library.say("e ", 300);
            library.say("a", 300);
            library.say("m ", 300);
            library.say("I", 300);
            library.say("?", 0);
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "You are in a game.";
            Console.WriteLine("You are in a game.");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
            library.say("W", 300);
            library.say("h", 300);
            library.say("a", 300);
            library.say("t ", 300);
            library.say("d", 300);
            library.say("o ", 300);
            library.say("y", 300);
            library.say("o", 300);
            library.say("u ", 300);
            library.say("m", 300);
            library.say("e", 300);
            library.say("a", 300);
            library.say("n", 300);
            library.say("?", 0);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "What is your name?";
            Console.WriteLine("What is your name?");
            string name;
            Console.ResetColor();
            do
            {
                name = Console.ReadLine();
            } while (name == "");

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Correct";
            Console.WriteLine("Correct");
            Console.ReadKey();
            Console.Write(name);
            Console.Write(name);
            Console.Write(name);
            Console.Write(name);
            Console.Write(name);
            Console.Write(name);
            Console.Write(name);
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.Red;
            library.say("HELP", 100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(name);
            Console.Write(name);
            Console.Write(name);
            Console.Write(name);
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.Red;
            library.say("HELP", 100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(name);
            Console.Write(name);
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.Red;
            library.say("HELP", 100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(name);
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.Red;
            library.say("HELP", 100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.Red;
            library.say("HELP", 100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "We remember";
            library.say("We ", 100);
            library.say("remember", 0);
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            library.say("REMEMBER", 500);
            Console.Clear();
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Hello, " + name + ". We missed you.";
            Console.WriteLine("Hello, " + name + ". Welcome back.");
            Console.Title = "Do you really want to leave?";
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine("1. Up\n2. Down\n3. Left\n4. Right\n5. Back");
            string direction;
            bool back = false;
            do
            {
                Console.ResetColor();
                direction = Console.ReadLine().ToLower();
                switch (direction)
                {
                    case "up":
                    case "1":
                    case "down":
                    case "2":
                    case "left":
                    case "3":
                    case "right":
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("There is nothing.");
                        break;

                    case "back":
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Where could you go back to?");
                        Console.ReadKey();
                        back = true;
                        break;

                    case "stay":
                        Console.Title = "Thank you.";
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Thank you.");
                        Console.ReadKey();
                        back = true;
                        break;

                    default:
                        Console.WriteLine("Wrong.");
                        break;
                }
            } while (!back);

            Console.ForegroundColor = ConsoleColor.Yellow;

            if (direction != "stay")
            {
                Console.Title = "Why do you want to leave us?";
                Console.WriteLine("Why do you want to leave us?");
                Console.ReadKey();
            }
            Console.Clear();
            Console.Title = "Let's Play a Game";
            Console.WriteLine("This isn't a very fun game, is it?");
            Console.WriteLine("We'll try to do better.");
            Console.ReadKey();
            Console.ResetColor();
            library.say("W", 300);
            library.say("h", 300);
            library.say("o ", 300);
            library.say("i", 300);
            library.say("s ", 300);
            library.say("\"", 300);
            library.say("w", 300);
            library.say("e", 300);
            library.say("\"", 300);
            library.say("?", 300);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You don't know.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Let's go to the right.");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string[] rightDesc = new string[7];
            rightDesc[0] = "In the room on the right you see a ";
            rightDesc[1] = "DOOR";
            rightDesc[2] = ", a ";
            rightDesc[3] = "WINDOW";
            rightDesc[4] = ", and a wall filled with ";
            rightDesc[5] = "FRAMED PHOTOS";
            rightDesc[6] = ".";
            Console.Write(rightDesc[0]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(rightDesc[1]);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(rightDesc[2]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(rightDesc[3]);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(rightDesc[4]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(rightDesc[5]);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(rightDesc[6]);
            bool door = false;
            bool window = false;
            bool photos = false;
            bool inspect = true;
            do
            {
                Console.WriteLine("What would you like to inspect?");
                Console.WriteLine("1. Door");
                Console.WriteLine("2. Window");
                Console.WriteLine("3. Photos");
                Console.WriteLine("4.Description");
                Console.ResetColor();
                string c = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Cyan;
                
                switch (c)
                {
                    case "1":
                    case "1.":
                    case "door":
                    case "go to door":
                        Console.WriteLine("You are in a bathroom. "+
                            "There is a mirror on the wall. Something is written on the mirror.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("My name is " + 
                            name.ToUpper() + " " + "My name is " + name.ToUpper() + " "
                            + "My name is " + name.ToUpper() + "");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You cannot see your face in the mirror.");
                        Console.ReadKey();
                        Console.Clear();
                        door = true;
                        if (door && window && photos)
                        {
                            inspect = false;
                        }//if
                        break;
                    case "2":
                    case "2.":
                    case "window":
                    case "go to window":
                        Console.WriteLine("Outside is black.");
                        Console.WriteLine("Or maybe there is nothing outside to see.");
                        Console.ReadKey();
                        Console.Clear();
                        window = true;
                        if (door && window && photos)
                        {
                            inspect = false;
                        }//if
                        break;
                    case "3":
                    case "3.":
                    case "photos":
                    case "wall":
                    case "photo":
                    case "go to wall":
                    case "go to photos":
                        Console.WriteLine("None of the photos have faces.");
                        Console.WriteLine("Your head hurts when you focus on them too much.");
                        Console.ReadKey();
                        Console.Clear();
                        photos = true;
                        if (door && window && photos)
                        {
                            inspect = false;
                        }//if
                        break;
                    case "4":
                    case "4.":
                    case "description":
                    case "describe":
                    case "room":
                        Console.Write(rightDesc[0]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(rightDesc[1]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(rightDesc[2]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(rightDesc[3]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(rightDesc[4]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(rightDesc[5]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(rightDesc[6]);

                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }//switch
            } while (inspect);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You can't remember.");
            Console.WriteLine("Let's go up.");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The only thing in the attic is a chest. Open it?");
            Console.ResetColor();
            string choice = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.Cyan;
            switch (choice)
            {
                case "yes":
                case "y":
                case "yeah":
                case "ye":
                case "yep":
                    Console.WriteLine("Your head aches trying to see past the static. " +
                        "You can almost make out a shape.\nA trophy. You squint. \"Number One \" "+
                        "Mom? Dad? Sis? Bro? You're not sure.\nAre you a parent? Are you a sibling?\n" +
                        "If there was more in the chest, your throbbing headache prevents you from seeing it.");
                    break;
                case "no":
                case "nah":
                case "n":
                case "nope":
                    Console.WriteLine("Some mysteries are best left alone.");
                    break;

                default:
                    Console.WriteLine("You're still incoherent from what you couldn't see in the previous room.\n" +
                        "You do not open the chest.");
                    break;
            }


        }//main()
    }//class
}//namespace
