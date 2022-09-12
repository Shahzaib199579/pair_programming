// See https://aka.ms/new-console-template for more information
using LastLetterSort;

var lastLetter = new LastLetterSortClass();
var result = lastLetter.SortByLastLetter("How are gate you");
foreach (var item in result)
{
    Console.WriteLine(item);
}