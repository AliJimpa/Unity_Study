using System;
namespace MachineLanguage
{

    public class Calculate{


        public static double compute(string math){
            math = math + ";";
            string Basenumber = "";
            string Result = "0";
            char lastfunc = '+';

            char[] fxchar = math.ToCharArray();
            foreach (var item in fxchar)
            {
                if ((int)char.GetNumericValue(item) != -1)
                {
                    Basenumber = Basenumber + item;
                }
                else
                {
                    if (item == '.')
                    {
                        Basenumber = Basenumber + item;
                    }
                    else
                    {
                        Result = RunFunction(lastfunc, double.Parse(Result), double.Parse(Basenumber)).ToString();
                        lastfunc = item;
                        Basenumber = "";
                    }
                }
            }
            return double.Parse(Result);
        }

        

        public static double Filternumber(string function){
            string number = "";
            char[] fxchar = function.ToCharArray();
            foreach (var item in fxchar)
            {
                if ((int)char.GetNumericValue(item) != -1)
                {
                    number = number + item;
                }
            }
            return double.Parse(number);
        }



        private static double RunFunction(char fx, double numberA, double numberB){
            double result;
            switch (fx)
            {
                case '+':
                    result = numberA + numberB;
                    break;
                case '*':
                    result = numberA * numberB;
                    break;
                case '-':
                    result = numberA - numberB;
                    break;
                case '/':
                    result = numberA / numberB;
                    break;
                case '^':
                    result = Math.Pow(numberA, numberB);
                    break;
                case '%':
                    result = numberA % numberB;
                    break;
                case '!':
                    result = Factorial((int)numberA);
                    break;
                default:
                    result = -100;
                    break;
            }
            return result;
        }

        private static int Factorial(int number){
            int i, fact = 1;
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }


    }

    public class Search
    {
        private static string game;


    }

    public class Filter
    {


        public static string Text(string text, string filter)
        {
            char[] chtext = text.ToCharArray();
            char[] chfilter = filter.ToCharArray();
            for (int i = 0; i < chtext.Length; i++)
            {
                if (chtext[i] == chfilter[0])
                {
                    int match = 0;
                    for (int j = 0; j < chfilter.Length; j++)
                    {
                        if (chfilter[j] == chtext[i + j])
                        {
                            match++;
                        }
                    }
                    
                    if (match == chfilter.Length)
                    {
                        for (int t = 0; t < match; t++)
                        {
                            chtext = Remove(chtext, i);
                        }
                    }

                }

            }
            return ChartoString(chtext);

        }



        private static char[] Remove(char[] _char, int _index)
        {
            char[] newchar = new char[(_char.Length - 1)];
            int j = 0;
            for (int i = 0; i < _char.Length; i++)
            {
                if (i != _index)
                {
                    newchar.SetValue(_char[i], j);
                    j++;
                }
            }
            return newchar;
        }

        private static string ChartoString(char[] _char)
        {
            string newstring = "";
            foreach (var item in _char)
            {
                newstring += item;
            }
            return newstring;
        }



    }

    public class IDE
    {

    }




}