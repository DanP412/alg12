using System;

namespace alg12
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Zadanie1("zakaz") == true && Zadanie1("robot") != true && Zadanie1("a") == true)
            {
                Console.WriteLine("Zadanie1 poprawne");
            }
            else
            {
                Console.WriteLine("Zadanie1 niepoprawne");
            }
            if (Zadanie2("abcca").Equals("ccc") && Zadanie2("abcccaddd").Equals("ccc") && Zadanie2("abcd").Equals("a")
                 )
            {
                Console.WriteLine("Zadanie2 poprawne");
            }
            else
            {
                Console.WriteLine("Zadanie2 niepoprawne");
            }
            if (Zadanie3("abc", "cab") == true && Zadanie3("abc", "cba") != true && Zadanie3("aabbcc", "abcabc") == true
                && Zadanie3("a", "a") == true && Zadanie3("", "") == true && Zadanie3("aaa", "aac") != true)
            {
                Console.WriteLine("Zadanie3 poprawne");
            }
            else
            {
                Console.WriteLine("Zadanie3 niepoprawne");
            }

            if (Zadanie4("100000", "1111111").Equals("121111111"))
            {

            }

        }

        //Czy input jest palidromem
        //input zawsze ma co najmniej jden znak
        public static bool Zadanie1(string input)
        {
            for (int i = 0; i < input.Length /2; i++)
            {
                if (input[i] != input[input.Length - i -1])
                {
                    return false;
                }
            }
            return true;
        }

        //znajdz i zwróć najdłuższy fragment złożony z jednakowych znaków

        public static string Zadanie2(string input)
        {
            string max = "";
            string result = "" + input[0];
            for (int i = 1; i < input.Length; i++)
            {
                char current = input[i];
                char prev = input[i - 1];
                if (current == prev)
                {

                    result += current;
                }
                else
                {
                    if (max.Length< result.Length)
                    {
                        max = result;
                    }
                    result = "" + current;
                }
            }
            return max.Length == 0 ? input[0] + "" : max;
        }

        //Sprawdz czy str1 jest anagramem str2
        public static bool Zadanie3(string str1, string str2)
        {
            char[] t1 = str1.ToCharArray();
            char[] t2 = str2.ToCharArray();
            Array.Sort(t1);
            Array.Sort(t2);
            for (int i = 0; i < t1.Length; i++)
            {
                if (t1[i] != t2[i])
                {
                    return false;
                }
            }
            return Array.Equals(t1, t2);

        }

        //Dodawanie dwóch lczb całkowitych zapisanych w łańcuchu
        public static string Zadanie4(string n1, string n2)
        {
            return "";
        }

        //Formatowanie do łańcuchów o długości nie większęj od n 
        public static string Zadanie5(string input, int n)
        {

        }

    }
}
