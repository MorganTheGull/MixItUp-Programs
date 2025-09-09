using System;
            
namespace CustomNamespace
{
    public class CustomClass
    {
        public object Run()
        {
            string chatMessage = "$username has layed ";
        
            // Eggs Layed
            if ($usercurrencysystemeggs == 1)
                chatMessage += "an egg. ";
            else
                chatMessage += "$usercurrencysystemeggs eggs. ";

            // Cooking the Egg
            Random rnd = new Random();
            int cookStyle = rnd.Next(1, 9); // (1,9) is a random int between 1 and 8.
            string cook = "This egg shall be eaten raw. Gross.";
            // Note: This was a switch statement, then I transferred it into the script section on the MixItUp Bot.
            // And it didn't work til I swapped it to an if-else. It always failed with the switch. >:/
            if (cookStyle == 1)
                cook = "Perhaps we boil this egg. But how do we want the yolk?";
            else if (cookStyle == 2)
                cook = "I'm thinking we poach this egg. A nice and runny yolk.";
            else if (cookStyle == 3)
                cook = "I'm feeling happy, so lets have the egg match. A nice sunny-side up egg.";
            else if (cookStyle == 4)
                cook = "Lets flip that egg a lil, and make it over easy.";
            else if (cookStyle == 5)
                cook = "Life is a lil chaotic. Shall we show that with our egg? A chaotic scrambled egg. YUM!";
            else if (cookStyle == 6)
                cook = "One baked egg coming up!";
            else if (cookStyle == 7)
                cook = "Is it getting steamy in here for anyone else? Cause this is becoming a steamed egg.";
            else if (cookStyle == 8)
                cook = "Omelet anyone? No, well to bad! One cheese and ham omelet coming up.";
            
            return chatMessage + cook;
        }
    }
}