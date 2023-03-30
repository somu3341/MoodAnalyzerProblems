using MoodAnalyzerProblems;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in a Sad Mood";
            MoodAnalyzer analyzer = new MoodAnalyzer(message);
            string result = analyzer.AnalyzeMood();
            Assert.AreEqual("SAD",result);
        }
        [Test]
        public void GivenAnyMood_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in a Any Mood";
            MoodAnalyzer analyzer = new MoodAnalyzer(message);
            string result = analyzer.AnalyzeMood();
            Assert.AreEqual("HAPPY", result);
        }
    }
}