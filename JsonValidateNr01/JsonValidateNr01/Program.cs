using System;

namespace JsonValidateNr01
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ValidateJsonNr(input);
            Console.Read();
        }

        public static bool ValidateJsonNr(string input)
        {
            bool result = true;
            for(int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '-':
                        if(i == 0 || input[i - 1] == 'E')
                        {
                            continue;
                        }
                        return false;
                    case '.':
                        if (input[i - 1] - 48 >= 0 && input[i - 1] - 48 <= 9 || input[i + 1] - 48 >= 0 && input[i + 1] - 48 <= 9)
                        {
                            continue;
                        }
                        return false;
                    case 'e':
                        {
                            if ((input[i - 1] - 48 >= 0 && input[i - 1] - 48 <= 9) && input[i + 1] - 48 >= 0 && input[i + 1] - 48 <= 9
                                || input[i + 1] =='+' && (input[i + 1] - 48 >= 0 && input[i + 1] - 48 <= 9)
                                || input[i + 1] == '-' && (input[i + 1] - 48 >= 0 && input[i + 1] - 48 <= 9))
                            {
                                continue;
                            }
                            return false;
                        }
                    default:
                        if (input[i] - 48 >= 1 && input[i] - 48 <= 9)
                        {
                            continue;
                        }
                        else
                            return false;
                }
                
            }
            return result;
        }
    }
}
