using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using ANDREICSLIB;

namespace Phrase_Profiler
{
    public static class controller
    {
        public static model M;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="options"></param>
        /// <returns>return null if no error, and return an error string if there was one</returns>
        public static string LoadFiles(List<string> filename, textoptions options)
        {
            var files = "";
            foreach (var f in filename)
            {
                var s = FileUpdates.LoadFile(f);
                if (s == null)
                    return f;

                if (string.IsNullOrEmpty(s))
                    continue;
                files += "\n" + s;
            }

            if (string.IsNullOrWhiteSpace(files))
                return null;

            M = new model(SanatiseFile(files, options),filename);
            
            return null;
        }

        public static void Refresh(List<String> excludedWords, List<string> requiredWords, Chart wordsChart,Chart phrasesChart, bool min3wordphrases,bool phrasecull)
        {
            int c = ChartMethods.itemMax;
            var words = M.GetTopWords(c, excludedWords,requiredWords);
            ChartMethods.SetChart(words, wordsChart);

            var phrases = M.GetTopPhrases(c, excludedWords, requiredWords, min3wordphrases, phrasecull);
            ChartMethods.SetChart(phrases, phrasesChart);
        }

        private static List<List<string>> SanatiseFile(string filestr, textoptions options)
        {
            var sepNewLine = new[] { "\r\n", "\n" };
            var sepWord = new[] { " " };
            var sepWordChar = new[] { ' ' };
            //split by new lines
            var lines = filestr.Split(sepNewLine, StringSplitOptions.RemoveEmptyEntries);

            var output = new List<List<string>>();

            //split into words
            foreach (var sentence in lines)
            {
                var sentence1 = sentence;

                if (options.ignoreHTML)
                    sentence1 = Regex.Replace(sentence1, "<.*?>", "");

                if (options.ignoreNonAlpha)
                    sentence1 = StringUpdates.RemoveAllNonAlphabetChars(sentence1);

                //trim trailing whitespace
                sentence1 = sentence1.Trim(sepWordChar);

                if (String.IsNullOrWhiteSpace(sentence1))
                    continue;

                var words = sentence1.Split(sepWord, StringSplitOptions.RemoveEmptyEntries);

                var newSentence = new List<string>();
                foreach (var word in words)
                {
                    var word1 = word;

                    word1 = word1.ToLower();

                    if (word1.Length > 0)
                    {
                        newSentence.Add(word1);
                    }
                }

                if (newSentence.Count > 0)
                    output.Add(newSentence);
            }

            return output;
        }


    }
}
