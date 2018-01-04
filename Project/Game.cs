using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project {

    public class Game : IGame {
        public bool Running = false;
        public Room ActiveRoom { get; set; }
        public Player Character { get; set; }

        public void Run () {
            DisplayActiveRoom ();
            string input;
            Running = true;
            while (Running) {
                input = handleInput ();
                Console.Clear ();
                switch (input.ToLower ()) {
                    case "!exit":
                        Console.Clear ();
                        Console.WriteLine ("");
                        Console.WriteLine (Character.Name + @"...  


 $$$$$$\  $$$$$$\ $$$$$$$$\        $$$$$$\  $$\   $$\ $$$$$$$\  
$$  __$$\ \_$$  _|\__$$  __|      $$  __$$\ $$ |  $$ |$$  __$$\ 
$$ /  \__|  $$ |     $$ |         $$ /  \__|$$ |  $$ |$$ |  $$ |
$$ |$$$$\   $$ |     $$ |         $$ |$$$$\ $$ |  $$ |$$ |  $$ |
$$ |\_$$ |  $$ |     $$ |         $$ |\_$$ |$$ |  $$ |$$ |  $$ |
$$ |  $$ |  $$ |     $$ |         $$ |  $$ |$$ |  $$ |$$ |  $$ |
\$$$$$$  |$$$$$$\    $$ |         \$$$$$$  |\$$$$$$  |$$$$$$$  |
 \______/ \______|   \__|          \______/  \______/ \_______/ 
                                                                
                                                                
                                                                ");
                        Console.WriteLine ("");
                        System.Environment.Exit (0);
                        continue;
                    case "!clear":
                        Console.Clear ();
                        continue;
                    case "no":
                        Console.WriteLine ("Whoa, hold on. Let's be rational here!\t\t type - why");
                        Console.WriteLine ("");
                        continue;
                    case "why":
                        Console.WriteLine ("Because if you don't play along, you'll lose the game. ^_^\t\t type - that's lame");
                        Console.WriteLine ("");
                        continue;
                    case "gg":
                        Console.WriteLine (Character.Name + ", you won the game. *cough CHEATER cough cough*");
                        Console.WriteLine ("");
                        continue;
                    case "yo":
                        Console.WriteLine ("Yo...");
                        Console.WriteLine ("");
                        continue;
                    case "hello":
                        Console.WriteLine ("Hello there! Thanks for dropping by. It can get really lonely around here since the admin doesn't update this stuff too often. RIP");
                        Console.WriteLine ("");
                        continue;
                    case "hi":
                        Console.WriteLine (@"Hi! Glad to see someone is still alive around here! Please help yourself to... 
*looks around* Oh. Nevermind, my creator is too lazy to add furniture and snacks. 
You can enjoy the scenery though! *Nothing but a thick fog covers the area*
Uhhh, why don't you just move along before this gets more awkward.
                        ");
                        Console.WriteLine ("");
                        continue;
                    case "that's lame":
                        Console.WriteLine ("Ok that's it. If you don't want to play along, I'll just end the game right here.");
                        Console.WriteLine ("Goodbye... " + Character.Name + ". You lose the game... For reasons...");
                        Console.WriteLine ("");
                        System.Environment.Exit (0);
                        continue;
                    case "what":
                        Console.WriteLine ("What do you mean what? Win the game already and give my creator a good grade! @_@");
                        Console.WriteLine ("");
                        continue;
                    case "!gear":
                        if (Character.Inventory.Count == 0) {
                            Console.WriteLine ();
                            Console.WriteLine ("RIP, nothing");
                        } else if (Character.Inventory.Count > 0) {
                            Console.WriteLine ();
                            Console.WriteLine ("You find: ");
                            foreach (var item in Character.Inventory) {
                                Console.Write ($"{item.Name} \"{item.Description}\" | ");
                            }
                        }
                        continue;
                    case "!look":
                        DisplayActiveRoom ();
                        continue;
                    case "!take":
                        TakeItem (Console.ReadLine ());
                        continue;
                    case "!leave":
                        if (ActiveRoom.Name == "4") {
                            if (Character.Inventory.Find (item => item.Name == "trophy") != null) {
                                Console.WriteLine ("GG " + Character.Name);
                                System.Environment.Exit (0);
                                continue;
                            } else {
                                continue;
                            }
                        } else { continue; }
                    case "!help":
                        Console.WriteLine ("");
                        Console.WriteLine ("What do you want " + Character.Name + "? You barely started the game and you need the GM's assistance ALREADY?! PFFFFF...");
                        Console.WriteLine ("Look around\t\t!look");
                        Console.WriteLine ("Use item\t\t!item");
                        Console.WriteLine ("Go Left\t\t\t!left");
                        Console.WriteLine ("Go Right\t\t!right");
                        Console.WriteLine ("Clear the console\t!clear");
                        Console.WriteLine ("Exit Game\t\t!exit");
                        Console.WriteLine ("Easter egg conversations. Type - no || what || gg");
                        Console.WriteLine ("");
                        continue;
                    case "!left":
                        go ("left");
                        continue;
                    case "!right":
                        go ("right");
                        continue;
                    default:
                        Console.WriteLine (@"Invalid input... Do you need help? 
                        Type !help for help.");
                        continue;
                }
            }
        }
        private void DisplayActiveRoom () {
            Console.Clear ();
            System.Console.WriteLine ("");
            System.Console.WriteLine (@"
                
 ▄████▄  ▄▄▄       ██████▄▄▄█████▓██▓   ▓█████         ▄████ ██▀███   ██ ▓███▄ ▄███▄▄▄█████▓▒█████  ██▓    
▒██▀ ▀█ ▒████▄   ▒██    ▒▓  ██▒ ▓▓██▒   ▓█   ▀        ██▒ ▀█▓██ ▒ ██▓ ██ ▓██▒▀█▀ ██▓  ██▒ ▓▒██▒  ██▓██▒    
▒▓█    ▄▒██  ▀█▄ ░ ▓██▄  ▒ ▓██░ ▒▒██░   ▒███         ▒██░▄▄▄▓██ ░▄█ ▒ ██ ▓██    ▓██▒ ▓██░ ▒▒██░  ██▒██░    
▒▓▓▄ ▄██░██▄▄▄▄██  ▒   ██░ ▓██▓ ░▒██░   ▒▓█  ▄       ░▓█  ██▒██▀▀█▄ ░ ██ ▒██    ▒██░ ▓██▓ ░▒██   ██▒██░    
▒ ▓███▀ ░▓█   ▓██▒██████▒▒ ▒██▒ ░░██████░▒████▒      ░▒▓███▀░██▓ ▒██░ ██ ▒██▒   ░██▒ ▒██▒ ░░ ████▓▒░██████▒
░ ░▒ ▒  ░▒▒   ▓▒█▒ ▒▓▒ ▒ ░ ▒ ░░  ░ ▒░▓  ░░ ▒░ ░       ░▒   ▒░ ▒▓ ░▒▓░ ▓  ░ ▒░   ░  ░ ▒ ░░  ░ ▒░▒░▒░░ ▒░▓  ░
  ░  ▒    ▒   ▒▒ ░ ░▒  ░ ░   ░   ░ ░ ▒  ░░ ░  ░        ░   ░  ░▒ ░ ▒░ ▒  ░  ░      ░   ░     ░ ▒ ▒░░ ░ ▒  ░
░         ░   ▒  ░  ░  ░   ░       ░ ░     ░         ░ ░   ░  ░░   ░  ▒  ░      ░    ░     ░ ░ ░ ▒   ░ ░   
░ ░           ░  ░     ░             ░  ░  ░  ░            ░   ░      ░        ░              ░ ░     ░  ░
░                                                                      
                                  
                ");
            System.Console.WriteLine ("ActiveRoom: " + ActiveRoom.Name + " ");
            System.Console.WriteLine (ActiveRoom.Description);
            foreach (var exit in ActiveRoom.Exits) {
                System.Console.Write (exit.Key + @"/
                
                ");
            }
            System.Console.WriteLine (@"
                                     ___ _____ _____ __  __ ____                                                                                                  
                                    |_ _|_   _| ____|  \/  / ___|                                                                                                 
  _____ _____ _____ _____ _____ _____| |  | | |  _| | |\/| \___ \ _____ _____ _____ _____ _____ _____ _____ _____ _____ _____ _____ _____ _____ _____ _____ _____ 
 |_____|_____|_____|_____|_____|_____| |  | | | |___| |  | |___) |_____|_____|_____|_____|_____|_____|_____|_____|_____|_____|_____|_____|_____|_____|_____|_____|
                                    |___| |_| |_____|_|  |_|____/                                                                                                 
                                                                                                                                                                  
            ");
            foreach (var item in ActiveRoom.Items) {
                System.Console.Write ($"{item.Name}");
            }
        }

        public void go (string direction) {
            if (ActiveRoom.Exits.ContainsKey (direction)) {
                ActiveRoom = ActiveRoom.Exits[direction];
                DisplayActiveRoom ();
            } else {
                Console.WriteLine ("Invalid input... Do you need help? Type !help for help.");
                return;
            }
        }
        public string handleInput () {
            System.Console.Write ("~");
            return System.Console.ReadLine ();
        }
        public void Reset () {
            throw new System.NotImplementedException ();
        }
        public void Setup () {
            var room1 = new Room ("1", "A small room with only 1 door. Only 1 way to go. Right");
            var room2 = new Room ("2", "A small room with 2 doors. 2 ways to go.");
            var room3 = new Room ("3", "A small room with 2 doors. 2 ways to go.");
            var room4 = new Room ("4", "There seems to be a computer sitting atop a desk with a chair, waiting to be used. The computer somehow has power. You may also go Left and return to the previous room.");
            room1.Exits.Add ("right", room2);
            room2.Exits.Add ("left", room1);
            room2.Exits.Add ("right", room3);
            room3.Exits.Add ("left", room2);
            room3.Exits.Add ("right", room4);
            room4.Exits.Add ("left", room3);
            ActiveRoom = room1;
            var key = new Item ("Digital Skeleton Key", "Last I checked. P v NP was not solved. This item is VERY valuable.");
            room3.Items.Add (key);
        }
        private void TakeItem (string itemName) {
            var Item = ActiveRoom.Items.Find (item => item.Name == itemName);
            if (Item != null) {
                Character.Inventory.Add (Item);
                ActiveRoom.Items.Remove (Item);
            }
        }
        public void UseItem (string itemName) {

        }

        public Game () { }
    }
}