﻿using System;
using CastleGrimtol.Project;
namespace CastleGrimtol {
    public class Program {
        public static void Main (string[] args) {
            bool playing = true;
            Game game = new Game ();
            // Do fancy
            game.Setup ();
            Console.Clear ();
            Console.WriteLine ("Name your person thingy:");
            var input3 = game.handleInput ();
            var player1 = new Player (input3);
            Console.WriteLine ("");
            Console.WriteLine ("Your character is now named " + player1.Name + "!");
            Console.WriteLine ("");
            Console.WriteLine (@"
            This... Is
                
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
            Console.WriteLine ("Welcome! You will be exploring the fantastic world of 'Pure Imagination' ");
            Console.WriteLine ("");
            Console.WriteLine ("Type !start to begin.");
            Console.WriteLine ("");
            while (playing) {
                // Name please
                game.Character = player1;
                var input2 = game.handleInput ().ToLower ();
                switch (input2) {
                    case "!exit":
                        Console.Clear ();
                        Console.WriteLine ("");
                        Console.WriteLine (player1.Name + @"... 


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
                        Environment.Exit (0);
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
                        Console.WriteLine ("Dude, you won the game. *cough CHEATER cough cough*");
                        Console.WriteLine ("");
                        continue;
                    case "yo":
                        Console.WriteLine ("Yo...");
                        Console.WriteLine ("");
                        continue;
                    case "where am i?":
                        Console.WriteLine ("Did we NOT just start the game? What does it say at the top of the screen huh? Sheesh... Noob...");
                        Console.WriteLine ("");
                        continue;
                    case "42":
                        Console.WriteLine (@"
By google's definition, you have solved the meaning to life and everything else that concerns you.
Too bad though, this castle doesn't give two sticks about your google magic.
As you were Adventurer...
                        ");
                        Console.WriteLine ("");
                        continue;
                    case "asl?":
                        Console.WriteLine (@"
I know where you're going with this... 
Don't... Just leave before I call the FBI...");
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
 Uhhh, why don't you just move along before this gets more awkward.");
                        Console.WriteLine ("");
                        continue;
                    case "that's lame":
                        Console.WriteLine ("Ok that's it. If you don't want to play along, I'll just end the game right here.");
                        Console.WriteLine ("Goodbye " + player1.Name + ". You lost the game for... Reasons...");
                        Console.WriteLine ("");
                        Environment.Exit (0);
                        continue;
                    case "what":
                        Console.WriteLine ("What do you mean what? Win the game already and give my creator a good grade! @_@");
                        Console.WriteLine ("");
                        continue;
                    case "dude":
                        Console.WriteLine ("Don't dude me! I don't even think " + player1.Name + " is your real name. That's right... I'm onto you...");
                        Console.WriteLine ("");
                        continue;
                    case "!help":
                        Console.WriteLine (@" 
Possible Commands
-------------------------
Start the game!!!   !start
Clear the console   !clear
Exit Game           !exit
-------------------------
Easter egg conversations.
-------------------------
no
why
this is lame
42
asl?
gg
yo
where am i?
hello
hi
what
dude
-------------------------
You may now return to your regularly scheduled adventure.
Type !start when you are ready to continue
                        ");
                        Console.WriteLine ("");
                        continue;
                    case "!start":
                        Console.Clear ();
                        Console.WriteLine ("Oh boy, here we go...");
                        Console.WriteLine ("");
                        game.Run ();
                        break;
                    default:
                        Console.WriteLine (@"Invalid input... Do you need help? 
                        Type !help for help.");
                        Console.WriteLine ("");
                        continue;
                }
            }
        }
    }
}