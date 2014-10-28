using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_2_2
{
    public static class TextAnalyzer
    {
        public static WordList Analyze(TextWork text)
        {
            WordList result = new WordList();

            for (int page = 1; page <= text.TextPole.Count(); page++)
            {
                for (int line = 1; line <= text.TextPole[page - 1].PagePole.Count(); line++)
                {
                    Regex reg = new Regex(@"\w{1,}");
                    MatchCollection mat = reg.Matches(text.TextPole[page - 1].PagePole[line - 1].LinePole);
                    
                    foreach (Match i in mat)
                    {
                        result.WordOccurence(new Word(i.ToString().ToLower()), new PageNumber(page), new LineNumber(line));
                    }
                }
            }

            return result;
        }
    }
}