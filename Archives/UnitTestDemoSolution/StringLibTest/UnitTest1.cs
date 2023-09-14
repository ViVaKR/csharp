
using StringLibrary;

namespace StringLibTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestStartsWithUpper()
    {
        // Tests that we expect to return true.
        string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
        foreach (var word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.IsTrue(result,
                   string.Format("Expected for '{0}': true; Actual: {1}",
                                 word, result));
        }
    }

    [TestMethod]
    public void TestDoesNotStartWithUpper()
    {
        // Tests that we expect to return false.
        // 테스트 통과 테스트
        string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " " };

        // 테스트 실패 유도 부분
        // string[] words = { "alphabet", "MakeErrorPosition", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
        //            "1234", ".", ";", " " };

        foreach (var word in words)
        {
            bool result = word.StartsWithUpper();
            Assert.IsFalse(result, $"기대 값 = '{word}': false; 실제 값 = {result}");
        }
    }

    [TestMethod]
    public void DirectCallWithNullOrEmpty()
    {
        // Tests that we expect to return false.
        string?[] words = { string.Empty, null };
        foreach (var word in words)
        {
            bool result = StringLibrary.StringLibrary.StartsWithUpper(word);
            Assert.IsFalse(result,
                   string.Format("Expected for '{0}': false; Actual: {1}",
                                 word ?? "<null>", result));
        }
    }
}