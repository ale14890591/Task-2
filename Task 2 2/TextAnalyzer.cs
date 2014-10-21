using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public static class TextAnalyzer
    {
        private static TextWork Normalize(TextWork text)
        {
            List<List<string>> normalizedText = new List<List<string>>();

            for (int page = 0; page < text.Text.Count; page++)
            {
                List<string> Page = new List<string>();

                for (int line = 0; line < text.Text[page].Count; line++)
                {
                    List<char> Line = text.Text[page][line].ToList<char>();
                    
                    //bool nextLineIsNewSentence = false;
                    //if (Line[Line.Count - 1] == '.' || Line[Line.Count - 1] == '?' || Line[Line.Count - 1] == '!')
                    //    nextLineIsNewSentence = true;

                    for (int symbol = Line.Count - 1; symbol >= 0; symbol--)
                    {
                        //try
                        //{
                        //    if (Char.IsLetter(Line[symbol]) && Char.IsUpper(Line[symbol]) &&
                        //        (Line[symbol - 2] == '.' || Line[symbol - 2] == '?' || Line[symbol - 2] == '!'))
                        //    {
                        //        Line[symbol] = Char.ToLower(Line[symbol]);
                        //        continue;
                        //    }
                        //}
                        //catch(IndexOutOfRangeException)
                        //{

                        //}

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

        public static WordList Analyze(TextWork text)
        {
            WordList result = new WordList();

            text = Normalize(text);

            for (int page = 1; page <= text.Text.Count(); page++)
            {
                for (int line = 1; line <= text.Text[page - 1].Count(); line++)
                {
                    string[] words = text.Text[page - 1][line - 1].Split(' ');

                    for (int i = 0; i < words.Length; i++)
                    {
                        result.WordOccurence(words[i], page, line);
                    }
                }
            }

            return result;
        }
    }
}