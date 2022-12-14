using FluentAssertions;
using NUnit.Framework.Internal;

namespace LastLetterSort.Tests;

public class LastLetterSortClassTest
{
    private LastLetterSortClass _lastLetterSort;
    [SetUp]
    public void Setup()
    {
        _lastLetterSort = new LastLetterSortClass();
    }

    [Test]
    public void Sort_By_Method_Should_Return_Empty_Array_When_Input_Empty_Or_Null()
    {
        var result = _lastLetterSort.SortByLastLetter("");
        result.Count().Should().Be(0);

        result = _lastLetterSort.SortByLastLetter(null);
        result.Count().Should().Be(0);
    }

    [Test]
    public void Sort_By_Method_Should_Return_Correctly_Sorted_List()
    {
        var result = _lastLetterSort.SortByLastLetter("How are you gate");

        var expectedResult = new List<string> { "are", "gate", "you", "How" };

        for (int i = 0; i < result.Count; i++)
        {
            result[i].Should().Be(expectedResult[i]);
        }
    }
}