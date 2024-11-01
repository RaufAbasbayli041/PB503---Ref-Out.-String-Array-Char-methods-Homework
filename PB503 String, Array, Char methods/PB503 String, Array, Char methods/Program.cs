namespace PB503_String__Array__Char_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1

            //Console.WriteLine("Enter password: ");
            //string password = Console.ReadLine();

            //bool result = ValidatePassword(password);

            //if (result)
            //{
            //    Console.WriteLine("Correct password");
            //}

            #endregion

            #region Task2

            string word = "Hello, world!";
            // Console.WriteLine(Replace(word));
            //Console.WriteLine(Substring(word));
            string trimWord = "--Hello,--world!-";
            Console.WriteLine(Trim(trimWord));
            #endregion
        }

        static bool ValidatePassword(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length < 8)
                {
                    Console.WriteLine("password's length is lower than 8 elements");
                    return false;
                }
                else if (!char.IsUpper(password[0]))
                {
                    Console.WriteLine("first letter is not upper ");
                    return false;
                }
            }

            bool containSymbol = false;
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    containSymbol = true;
                    break;
                }
            }
            if (!containSymbol)
            {
                Console.WriteLine("password doesn't contain any symbols");
                return false;
            }

            bool containNumber = false;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    containNumber = true;
                    break;
                }
            }
            if (!containNumber)
            {
                Console.WriteLine("password doesn't contain any numbers");
                return false;
            }

            return true;
        }

        static string Replace(string replacedWord)
        {
            string replaceWord1 = string.Empty;

            string inputWord = "Hey";

            for (int i = 0; i < replacedWord.Length; i++)
            {
                if (i >= 0 && i <= 4)
                {
                    continue;
                }
                replaceWord1 += replacedWord[i];
            }

            string replacedWord2 = inputWord + replaceWord1;

            return replacedWord2;
        }

        static string Substring(string substringWord)
        {
            string substringNewWord = string.Empty;

            for (int i = 0; i < substringWord.Length; i++)
            {
                if (i >= 7 && i <= substringWord.Length - 1)
                {
                    substringNewWord += substringWord[i];
                }
            }

            return substringNewWord;
        }

        static string Trim(string trimWord)
        {
            string trimNewWord1 = string.Empty;
            int startIndex = 0;

            while (startIndex >= 0 && trimWord[startIndex] == '-')
            {
                startIndex++;
            }
            for (int i = startIndex; i < trimWord.Length; i++)
            {

                trimNewWord1 += trimWord[i];
            }

            string trimNewWord2 = string.Empty;
            int endIndex = trimNewWord1.Length - 1;

            while (endIndex >= 0 && trimNewWord1[endIndex] == '-')
            {
                endIndex--;
            }
            for (int i = 0; i <= endIndex; i++)
            {
                trimNewWord2 += trimNewWord1[i];
            }

            return trimNewWord2;
        }

    }
}
