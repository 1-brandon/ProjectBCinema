using System;

namespace movie_info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|=========================================|");
            Console.WriteLine("|----------  select your movie  ----------|");
            Console.WriteLine("|=========================================|");
            Console.WriteLine();
            Console.WriteLine("1 |SpiderMan \n2 |Mission impossible \n3 |Black Widow \n4 |JamesBond \n5 |JohnWick");
            Console.WriteLine("6 |BAD BOYS \n7 |Birds of Prey \n8 |Sonic \n9 |Bloodshot \n10|MULAN");
            Console.WriteLine();


            Console.WriteLine("Enter the number of the movie you want to select please:");
            string moviePicked = Console.ReadLine();
            Console.WriteLine();


            string movie_1 = "1";
            string movie_2 = "2";
            string movie_3 = "3";
            string movie_4 = "4";
            string movie_5 = "5";
            string movie_6 = "6";
            string movie_7 = "7";
            string movie_8 = "8";
            string movie_9 = "9";
            string movie_10 = "10";

            string information = "";



            if (moviePicked == movie_1)
            {
                information = "title: SPIDERMAN: Far From Home\n" +
                    "-------DESCRIPTION-------\n" +
                    "Our friendly neighborhood Super Hero decides to join his best friends Ned, MJ, and the rest of the gang on a European vacation.\n" +
                    "However, Peter's plan to leave super heroics behind for a few weeks are quickly scrapped when he begrudgingly agrees to help Nick Fury uncover the mystery of several elemental creature attacks, creating havoc across the continent." +
                    "\n" +
                    "Director: Jon Watts\n" +
                    "Writers: Chris McKenna, Erik Sommers, Stan Lee, Steve Ditko  \n" +
                    "Strars: Tom Holland\n      Samuel L. Jackson\n      Jake Gyllenhaal\n";
            }
            if (moviePicked == movie_2)
            {
                information = "title: MISSIONS IMPOSSIBLE: Fallout\n" +
                    "-------DESCRIPTION-------\n" +
                    "Two years after Ethan Hunt had successfully captured Solomon Lane, the remnants of the Syndicate have reformed into another organization called the Apostles.\n" +
                    "Under the leadership of a mysterious fundamentalist known only as John Lark, the organization is planning on acquiring three plutonium cores.\n" +
                    "Ethan and his team are sent to Berlin to intercept them, but the mission fails when Ethan saves Luther and the Apostles escape with the plutonium.\n" +
                    "With CIA agent August Walker joining the team, Ethan and his allies must now find the plutonium cores before it's too late.\n" +
                    "\n" +
                    "Director: Christopher McQuarrie\n" +
                    "Writers: Bruce Geller, Christopher McQuarrie  \n" +
                    "Stars:\n Tom Cruise\n Henry Cavill\n Ving Rhames\n";
            }
            if (moviePicked == movie_3)
            {
                information = "title: BLACK WIDOW\n" +
                    "-------DESCRIPTION-------\n" +
                    "In Marvel Studios’ action-packed spy thriller “Black Widow,” Natasha Romanoff aka Black Widow confronts the darker parts of her ledger when a dangerous conspiracy with ties to her past arises\n" +
                    "Pursued by a force that will stop at nothing to bring her down, Natasha must deal with her history as a spy and the broken relationships left in her wake long before she became an Avenger.\n" +
                    "\n" +
                    "Director: Cate Shortland\n" +
                    "Writers: Stan Lee, Jac Schaeffer, Ned Benson, Don Heck, Don Rico \n" +
                    "Cast: Scarlett Johansson, David Harbour, Florence Pugh, O-T Fagbenle, and Rachel Weisz\n";
            }
            if (moviePicked == movie_4)
            {
                information = "title: JAMES BOND: No time to die\n" +
                    "-------DESCRIPTION-------\n" +
                    "In No Time To Die, Bond has left active service and is enjoying a tranquil life in Jamaica.\n" +
                    "His peace is short-lived when his old friend Felix Leiter from the CIA turns up asking for help.\n" +
                    "The mission to rescue a kidnapped scientist turns out to be far more treacherous than expected, leading Bond onto the trail of a mysterious villain armed with dangerous new gadgets\n" +
                    "\n" +
                    "Director: Cary Joji Fukunaga\n" +
                    "Writers:  Neal Purvis, Robert Wade \n" +
                    "Stars:\n Ana de Armas\n     Daniel Craig\n      Ralph Fiennes\n";
            }
            if (moviePicked == movie_5)
            {
                information = "title: JOHN WICK: Chapter 3 - Parabellum\n" +
                    "-------DESCRIPTION-------\n" +
                    "In this third installment of the adrenaline-fueled action franchise, skilled assassin John Wick (Keanu Reeves) returns with a $14 million price tag on his head and an army of bounty-hunting killers on his trail.\n" +
                    "After killing a member of the shadowy international assassin's guild, the High Table, John Wick is excommunicado, but the world's most ruthless hit men and women await his every turn.\n" +
                    "\n" +
                    "Director: Chad Stahelski\n" +
                    "Writers:  Derek Kolstad, Shay Hatten \n" +
                    "Stars:  Keanu Reeves, Halle Berry, Ian McShane\n";
            }
            if (moviePicked == movie_6)
            {
                information = "title: BAD BOYS FOR LIFE III\n" +
                    "-------DESCRIPTION-------\n" +
                    "Marcus and Mike have to confront new issues (career changes and midlife crises), as they join\n" +
                    "the newly created elite team AMMO of the Miami police department to take down the ruthless\n" +
                    "Armando Armas, the vicious leader of a Miami drug cartel.\n" +
                    "\n" +
                    "Director: Adil El Arbi & , Bilall Fallah \n" +
                    "Writers: Peter Craig, JOe Carnahan \n" +
                    "Cast: Will Smith, Martin Lawrence, Vanessa Hudgens \n";
            }
            if (moviePicked == movie_7)
            {
                information = "title: Birds of Prey: And the Fantabulous Emancipation of One Harley Quinn\n" +
                    "-------DESCRIPTION-------\n" +
                    "A twisted tale told by Harley Quinn herself, when Gotham's most nefariously narcissistic villain, Roman Sionis, and his zealous right-hand, Zsasz, put a target on a young girl named Cass, the city is turned upside down looking for her.\n" +
                    "Harley, Huntress, Black Canary and Renee Montoya's paths collide, and the unlikely foursome have no choice but to team up to take Roman down.\n" +
                    "\n" +
                    "Director: Cathy Yan\n" +
                    "Writers:  Christina Hodson, Paul Dini \n" +
                    "cast: Margot Robbie\n      Rosie Perez\n      Mary ELizabeth Winstead\n";
            }
            if (moviePicked == movie_8)
            {
                information = "title: Sonic the Hedgehog\n" +
                    "-------DESCRIPTION-------\n" +
                    "A twisted tale told by Harley Quinn herself, when Gotham's most nefariously narcissistic villain, Roman Sionis, and his zealous right-hand, Zsasz, put a target on a young girl named Cass, the city is turned upside down looking for her.\n" +
                    "Harley, Huntress, Black Canary and Renee Montoya's paths collide, and the unlikely foursome have no choice but to team up to take Roman down.\n" +
                    "\n" +
                    "Director: ***  ****\n" +
                    "Writers: ***** ******* \n" +
                    "Cast: ****** *****\n      ******* ****\n      *** ******\n";

            }
            if (moviePicked == movie_9)
            {
                information = "title: Bloodshot\n" +
                    "-------DESCRIPTION-------\n" +
                    "Based on the global blockbuster videogame franchise from Sega, SONIC THE HEDGEHOG tells the story of the world's speediest hedgehog as he embraces his new home on Earth.\n" +
                    "In this live-action adventure comedy, Sonic and his new best friend Tom (James Marsden) team up to defend the planet from the evil genius Dr. Robotnik (Jim Carrey) and his plans for world domination.\n" +
                    " The family-friendly film also stars Tika Sumpter and Ben Schwartz as the voice of Sonic.\n" +
                    "\n" +
                    "Director: Jeff Fowler\n" +
                    "Writers: Pat Casey, Josh Miller\n" +
                    "Stars: Ben Schwartz, James Marsden, Jim Carrey \n";

            }
            if (moviePicked == movie_10)
            {
                information = "title: MULAN\n" +
                    "-------DESCRIPTION-------\n" +
                    "A young Chinese maiden disguises herself as a male warrior in order to save her father. A live-action feature film based on Disney's 'Mulan.'\n" +
                    "\n" +
                    "Director: Niki Caro\n" +
                    "Writers: Rick Jaffa, Amanda Silver \n" +
                    "Strars: Yifei Liu, Donnie Yen, Li Gong \n";
            }
            else
            {
                Console.WriteLine("Please check if you typed the valid number for the specific movie");
            }


            Console.WriteLine(information);






        }
    }
}
 