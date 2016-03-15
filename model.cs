using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANDREICSLIB.ClassExtras;

namespace Phrase_Profiler
{

    public class textoptions
    {
        public readonly bool ignoreHTML;
        public readonly bool ignoreNonAlpha;

        public textoptions(bool ignoreHTML, bool ignoreNonAlpha)
        {
            this.ignoreHTML = ignoreHTML;
            this.ignoreNonAlpha = ignoreNonAlpha;
        }
    }

    public class model
    {
        public List<List<string>> sentences;
        public List<String> loadedFiles;

        public model(List<List<string>> sentences,List<string> filenames )
        {
            this.sentences = sentences;
            loadedFiles = filenames;
        }

        private static bool addCount(ref Dictionary<string, int> dic, string key)
        {
            bool existed = true;
            if (dic.ContainsKey(key) == false)
            {
                dic.Add(key, 0);
                existed = false;
            }

            dic[key]++;
            return existed;
        }

        public enum responses
        {
            CantAdd, AddedNoPrevious, AddedToPrevious
        }

        private responses OKPhrase(ref Dictionary<string, int> dic, string key, List<String> excludedPhrases, List<string> requiredPhrases, int mincount = 1)
        {
            if ((requiredPhrases.Count > 0 && requiredPhrases.Any(key.Contains) == false)
                || (excludedPhrases.Count > 0 && excludedPhrases.Any(key.Contains)))
                return responses.CantAdd;

            if (key.Count(char.IsWhiteSpace) < mincount)
                return responses.CantAdd;

            bool hit = addCount(ref dic, key);
            if (hit)
                return responses.AddedToPrevious;
            return responses.AddedNoPrevious;
        }

        public Dictionary<string, int> GetTopPhrases(int count, List<String> excludedPhrases, List<string> requiredPhrases, bool min3words, bool cull)
        {
            var phrases = new Dictionary<string, int>();
            int reqspace = 1;
            if (min3words)
                reqspace = 3;

            var parents = new HashSet<String>();

            foreach (var s in sentences)
            {
                //get all combos
                var xx = ListExtras.GetAllCombinations(s, 2, -1).OrderByDescending(pair => pair.Count).ToList();
                if (xx.Count == 0)
                    continue;

                String fullsentence = null;
                foreach (var sl in xx)
                {
                    var sentence = String.Join(" ", sl.ToArray());

                    if (fullsentence == null)
                    {
                        //empty value=no further parent
                        parents.Add(sentence);
                        fullsentence = sentence;
                    }

                    OKPhrase(ref phrases, sentence, excludedPhrases, requiredPhrases, reqspace);
                }
            }

            var ret = new Dictionary<string, int>();
            foreach (var kvp in phrases.OrderByDescending(pair => pair.Value).Take(count))
            {
                if (cull && kvp.Value == 1 && parents.Contains(kvp.Key))
                    continue;

                ret.Add(kvp.Key, kvp.Value);
            }

            return ret;

        }

        public Dictionary<string, int> GetTopWords(int count, List<String> excludedWords, List<string> requiredWords)
        {
            var words = new Dictionary<string, int>();
            foreach (var s in sentences)
            {
                foreach (var w in s)
                {
                    if (excludedWords.Any(w.Equals))
                        continue;

                    if (requiredWords.Count > 0 && requiredWords.Any(w.Contains) == false)
                        continue;

                    addCount(ref words, w);
                }
            }

            var ret = new Dictionary<string, int>();
            foreach (var kvp in words.OrderByDescending(pair => pair.Value).Take(count))
            {
                ret.Add(kvp.Key, kvp.Value);
            }

            return ret;
        }

    }
}
