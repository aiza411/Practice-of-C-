namespace Practice_Day1
{
    internal class Day1
    {
        static void Main(string[] args)
        {
            String name="Aiza";
            String age="19 years";
            String text=" Hello World            ";

            Console.WriteLine("Hello, World!");
            Console.WriteLine(name);
            Console.WriteLine("Hello, "+name);
            Console.WriteLine($"Hello, {name}");
            Console.WriteLine($"Hello, I am {name} and I am {age} old");


            //Removes all the leading white-space characters from the current string.
            String trim_text=text.TrimStart();
            Console.WriteLine($"Trim Start: {trim_text}");

            //Removes all the trailing white-space characters from the current string.
            trim_text=text.TrimEnd();
            Console.WriteLine($"Trim End: {trim_text}");

            //Removes all leading and trailing white-space characters from the current string.
            trim_text=text.Trim();
            Console.WriteLine($"Trim : {trim_text}");


            //Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
            String new_age=age.Replace("19","20");
            Console.WriteLine($"My new age is : {new_age}");

            String name_all_caps=name.ToUpper();
            Console.WriteLine(name_all_caps);

            String name_all_lower=name.ToLower();
            Console.WriteLine(name_all_lower);


            //Returns a value indicating whether a specified substring occurs within this string.
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine("String conatins letter goodbye : "+ songLyrics.Contains("goodbye"));
            Console.WriteLine("String conatins letter aiza : "+ songLyrics.Contains("aiza"));

        }
    }
}

