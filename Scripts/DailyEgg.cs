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
            int eggChoice = rnd.Next(1, 9); // (1,9) is a random int between 1 and 8.
			string[] eggCook = 
			{
				"Perhaps we boil this egg. But how do we want the yolk?",
				"I'm thinking we poach this egg. A nice and runny yolk.",
				"I'm feeling happy, so lets have the egg match. A nice sunny-side up egg.",
				"Lets flip that egg a lil, and make it over easy.",
				"Life is a lil chaotic. Shall we show that with our egg? A chaotic scrambled egg. YUM!",
				"One baked egg coming up!",
				"Is it getting steamy in here for anyone else? Cause this is becoming a steamed egg.",
				"Omelet anyone? No, well to bad! One cheese and ham omelet coming up.",
			};
            
            return chatMessage + eggCook[eggChoice];
        }
    }
}