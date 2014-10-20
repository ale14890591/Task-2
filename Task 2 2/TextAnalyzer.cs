using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class TextAnalyzer
    {
        public delegate void MethodContainerString(string x);
        public event MethodContainerString wordOccurence;

        public delegate void MethodContainerStringInt(string x, int y);
        public event MethodContainerStringInt wordOccurenceOnPage;

        WordList result;

        //public TextAnalyzer()
        //{
        //    result = new WordList();
        //    wordOccurence += result.WordCountIncrement;
        //    wordOccurenceOnPage += result.WordOccurenceOnPage;
        //}

        private static TextWork Normalizing(TextWork text)
        {
            List<List<string>> normalizedText = new List<List<string>>();

            for (int page = 0; page < text.Text.Count; page++)
            {
                List<string> Page = new List<string>();

                for (int line = 0; line < text.Text[page].Count; line++)
                {
                    List<char> Line = text.Text[page][line].ToList<char>();

                    for (int symbol = 0; symbol < Line.Count; symbol++)
                    {
                        if (Char.IsLetter(Line[symbol]) && Char.IsUpper(Line[symbol]))
                        {
                            Line[symbol] = Char.ToLower(Line[symbol]);
                            continue;
                        }
                        if (!Char.IsLetter(Line[symbol]) && Line[symbol] != ' ')
                        {
                            Line.Remove(Line[symbol]);
                        }
                    }

                    Page.Add(String.Concat(Line));
                }
                
                normalizedText.Add(Page);
            }

            return new TextWork(normalizedText);
        }

        public WordList Analyzing(TextWork textForAnalysis)
        {
            textForAnalysis = Normalizing(textForAnalysis);

             

            for (int page = 1; page <= textForAnalysis.Text.Count(); page++)
            {
                for (int line = 1; line <= textForAnalysis.Text[page - 1].Count(); line++)
                {
                    string[] words = textForAnalysis.Text[page - 1][line - 1].Split(' ');

                    for (int i = 0; i < words.Length; i++)
                    {
                        //if (!list.ContainsWord(words[i]))
                        //{
                        //    list.AddWord(words[i]);
                        //}

                        //list.WordOccurence(words[i]);
                        //list.WordOccurenceOnPage(words[i], page);
                    }
                }
            }

            return result;
        }
    }
}
