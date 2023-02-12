using System;
using System.Collections;

class Word
{    
    private static string scripture = "4 Love is patient, love is kind. It does not envy, it does not boast, it is not proud. 5 It does not dishonor others, it is not self-seeking, it is not easily angered, it keeps no record of wrongs. 6 Love does not delight in evil but rejoices with the truth. 7 It always protects, always trusts, always hopes, always perseveres. 8 Love never fails. But where there are prophecies, they will cease; where there are tongues, they will be stilled; where there is knowledge, it will pass away.";

    public bool isHidden = false;    
    
    // https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
        public string[] separateWords = scripture.Split(' ');
        public List<int> separateWordsIndex = new List<int>();
        public void DisplayWords()
        {
            foreach(string i in separateWords)
            {
                Console.Write($"{i} ");
            }
        }   
        public void DisplayHidden()
        {
            string hiddenWords = " _____ ";
            int y = separateWords.Length;           
            Random i = new Random();
            int w = i.Next(0, y);
                if(separateWordsIndex.Contains(w))
                {
                    Random n = new Random();
                    int v = i.Next(0,y);
                    separateWords[v] = hiddenWords;
                    separateWordsIndex.Add(v);
                }
                else
                {
                    separateWords[w] = hiddenWords;
                    separateWordsIndex.Add(w);
                }
            
            foreach(string z in separateWords)
            {
                Console.Write($" {z}");
            }
        }
        public void IsHidden()
        {
            if(separateWordsIndex.Count == 140)
            {
                isHidden = true;
            }
            else
            {
                isHidden = false;
            }
        }
}