using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastLetterSort
{
    public class LastLetterSortClass
    {
        public List<string> SortByLastLetter(string input)
        {
            if (String.IsNullOrEmpty(input))
                return new List<string>();

            var splitString = input.Split(" ");
            var characterDicitonary = new Dictionary<char, List<string>>();
            foreach (var sen in splitString)
            {
                if (characterDicitonary.Keys.Contains(sen[sen.Length - 1]))
                    characterDicitonary[sen[sen.Length - 1]].Add(sen);
                else
                {
                    characterDicitonary[sen[sen.Length - 1]] = new List<string>();
                    characterDicitonary[sen[sen.Length - 1]].Add(sen);
                }     
            }

            var sortResult = characterDicitonary.Keys.OrderBy(x => x);
            var solutionList = new List<string>();
            foreach (var k in sortResult)
            {
                if (characterDicitonary[k].Count == 0)
                    solutionList.Add(characterDicitonary[k].First());
                else
                {
                    foreach (var item in characterDicitonary[k])
                    {
                        solutionList.Add(item);
                    }
                }
            }

            return solutionList;
        }
    }
}
