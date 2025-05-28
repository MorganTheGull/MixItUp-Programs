using System;

namespace CustomNamespace
{
    public class CustomClass
    {
        public object Run()
        {
            // The Main Variable
            string arguments = "$allargs";
            if (arguments == "")
                return " ";

            // Check Food
            string[] foodArray = {"food", "breakfast", "lunch", "dinner", "cook", "snack", "brunch"};
            if (SearchArray(foodArray, arguments))
                return "food";

            // Check Games
            string[] gameArray = {"games", "play"};
            if (SearchArray(gameArray, arguments))
                return "game";
            
            // Check Sleep
            string[] sleepArray = {"rest", "sleep", "bedtime", "bed"};
            if (SearchArray(sleepArray, arguments))
                return "sleep";

            // Return empty string if not special
            return " ";
        }
        
        public bool SearchArray(string[] array, string arg)
        {
            foreach(var item in array)
            {
                if(arg.Contains(item))
                    return true;
            }
            return false;
        }
    }
}
