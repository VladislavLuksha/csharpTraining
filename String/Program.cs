using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Vodlad";
            string str2 = "Vadova";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            RandomSwap(str1, str2);
            // наиболее длинный общий фрагмент строк.
            Console.WriteLine("..........");
            string firstString = "tabccdehfupltyu";
            string secondString = "zxabcabccmkl";
            MaxElementsStrings(firstString, secondString);
        }
        static void RandomSwap(string firstLine, string secondLine)
        {
            Random rand = new Random((int)(DateTime.Now.Ticks/TimeSpan.TicksPerMillisecond));
            int startPosition = rand.Next(0, firstLine.Length-1);
            int numberOfSwappedLetters = rand.Next(1,firstLine.Length-1-startPosition);
            int endPosition = startPosition + numberOfSwappedLetters;
            StringBuilder firstLineBuilder = new StringBuilder(firstLine);
            StringBuilder secondLineBuilder = new StringBuilder(secondLine);
            char temp;
            for(int i=startPosition;i<=endPosition;i++)
            {
                temp = firstLine[i];
                firstLineBuilder[i] = secondLineBuilder[i];
                secondLineBuilder[i] = temp;
            }
            firstLine = firstLineBuilder.ToString();
            secondLine = secondLineBuilder.ToString();
            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
        }
        static void MaxElementsStrings(string firstString,string secondString)
        {
            StringBuilder firstStringBuider = new StringBuilder(firstString);
            StringBuilder secondStringBuilder = new StringBuilder(secondString);
            int positionTwoLine = 0;
            int positionOneLine = 0;
            string tempLine="";
            string secondLine="";
            StringBuilder tempLineBuilder = new StringBuilder(tempLine);
            StringBuilder secondLineBuilder = new StringBuilder(secondLine);
            bool flag = true;
            for(int i=0;i< firstStringBuider.Length-1;i++)
            {
                for(int j=0;j< secondStringBuilder.Length-1;j++)
                {
                    if(firstStringBuider[i]==secondStringBuilder[j])
                    {
                        positionTwoLine = j;
                        positionOneLine = i;
                        flag = false;
                        break;
                    }
                }
                if(flag==false)
                {
                    break;
                }
            }
            Console.WriteLine(positionOneLine);
            Console.WriteLine(positionTwoLine);
            char[] array1 = new char[5];
            bool flag1 = true;
            bool flag2 = true;
            int c = 0;
            int positionTwoLine1 = 0;
            for (int i = positionOneLine; i < firstStringBuider.Length-1; i++)
            {
                for (int j = positionTwoLine; j < secondStringBuilder.Length-1;j++)
                {
                    if (firstStringBuider[i] == secondStringBuilder[j])
                    {
                        array1[c] = secondStringBuilder[j];
                        c++;
                        flag1 = false;
                        positionTwoLine++;
                    }
                    else
                    {
                        positionTwoLine1 = positionTwoLine;
                        flag2 = false;
                    }
                    if(flag1==false)
                    break;
                }
                if (flag2 == false)
                    break;
            }
            char[] array2 = new char[5];
            int b = 0;
            bool flag3 = true;
            bool flag4 = true;
            for(int i=positionOneLine;i<firstStringBuider.Length-1;i++)
            {
                for (int j = positionTwoLine1; j < secondStringBuilder.Length - 1; j++)
                {
                    if (firstStringBuider[i] == secondStringBuilder[j])
                    {
                        array2[b] = secondStringBuilder[j];
                        b++;
                        flag3 = false;
                        positionTwoLine1++;
                    }
                    else
                    {
                        if
                    }
                    if (flag3 == false)
                        break;
                }
            }
            foreach(char element in array1)
            {
                Console.Write(element);
            }
        }
    }
}
