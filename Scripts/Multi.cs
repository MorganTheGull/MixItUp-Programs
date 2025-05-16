using System;
            
namespace CustomNamespace
{
    public class CustomClass
    {
        public object Run()
        {
            string arguments = "$allargs";
            if (arguments == "" || arguments == null)
                return "";
            
            string multiMessage = "Watch all sides of the action here at https://www.streamsquads.com/t:$streamerusername/t:";
        
            //remove any extra spaces
            while (arguments.Contains("  "))
                arguments = arguments.Replace("  ", " ");
            arguments.Trim();
        
            // Convert spaces into "/t:"
            while (arguments.Contains(" "))
                arguments = arguments.Replace(" ", "/t:");
        
            return (multiMessage + arguments);
        }
    }
}
