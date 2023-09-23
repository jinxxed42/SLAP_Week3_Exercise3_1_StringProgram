namespace SLAP_Week3_Exercise3_1_StringProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test cut with word \"Interpolation\":");
            Console.WriteLine(Str.Cut("Interpolation.", 5));
            Console.WriteLine(Str.Cut("Interpolation.", 35));
            Console.WriteLine();
            Console.WriteLine("Test pad left:");
            Console.WriteLine(Str.Left("Television.", 5, '*'));
            Console.WriteLine(Str.Left("Television.", 35, '*'));
            Console.WriteLine();
            Console.WriteLine("Test pad right:");
            Console.WriteLine(Str.Right("Television.", 5, '*'));
            Console.WriteLine(Str.Right("Television.", 35, '*'));
            Console.WriteLine();
            Console.WriteLine("Test pad both:");
            Console.WriteLine(Str.Center("Television.", 5, '*'));
            Console.WriteLine(Str.Center("Television.", 35, '*'));
            Console.WriteLine();
            Console.WriteLine("Test clear method with word \"Intermission\" and letter \'s\':");
            Console.WriteLine(Str.Clear("Intermission.", 's'));
            Console.WriteLine();

            string[] arr = new string[] { "you", "how", "doing" };
            Console.WriteLine("Testing split.");
            Console.WriteLine("String to split: \"Hello how are you doing hello hello it is a nice day\"");
            Console.WriteLine("Tokens to split by: \"you\", \"how\" and \"doing\"");
            Console.WriteLine("Test keep empty spaces:");
            
            List<string> list = Str.Split("Hello how are you doing hello hello it is a nice day", false, false, arr);
            foreach (string s in list)
            {
                Console.WriteLine($"|{s}|");
            }
            Console.WriteLine();
            Console.WriteLine("Test don't keep empty tokens:");
            list = Str.Split("Hello how are you doing hello hello it is a nice day", true, false, arr);
            foreach (string s in list)
            {
                Console.WriteLine($"|{s}|");
            }
            Console.WriteLine();
            Console.WriteLine("Test include separators as token and keep empty tokens:");
            list = Str.Split("Hello how are you doing hello hello it is a nice day", false, true, arr);
            foreach (string s in list)
            {
                Console.WriteLine($"|{s}|");
            }
            arr = new string[] { " ", "a" };
            Console.WriteLine();
            Console.WriteLine("Test with separators \" \" and \"a\", don't include separators:");
            list = Str.Split("Hello how are you doing hello hello it is a nice day", false, false, arr);
            foreach (string s in list)
            {
                Console.WriteLine($"|{s}|");
            }
            Console.WriteLine();
            Console.WriteLine("Test with separators \" \" and \"a\", include separators:");
            list = Str.Split("Hello how are you doing hello hello it is a nice day", false, true, arr);
            foreach (string s in list)
            {
                Console.WriteLine($"|{s}|");
            }
        }
    }
}