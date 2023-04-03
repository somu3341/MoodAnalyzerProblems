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
        [Test]
        public void GivenNullMood_ShouldThrow_Exception()
        {
            try
            {
                string message = "null";
                MoodAnalyzer analyzer = new MoodAnalyzer(message);
                string result = analyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }          
        }
        [Test]
        public void GivenEmptyMood_WhenAnalyze_ShouldReturn()
        {
            string message = "";
            string result = null;
            MoodAnalyzer analyzer = new MoodAnalyzer(message);
            try
            {
                result = analyzer.AnalyzeMood();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }
        [Test]
        public void GivenClassName_WhenAnanlyze_ShouldReturnMoodAnanlyzeObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            object obj = MoodAnalyzerFactory.CreatMoodAnalyzer("MoodAnalyzerProblems.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
        [Test]
        public void GivenClassNameImproper_WhenAnalyze_ShouldThrowException()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyzer(message);
                object obj = MoodAnalyzerFactory.CreatMoodAnalyzer("MAnalyzer.Mood_analyzer", "MoodAnalyzer");
                expected.Equals(obj);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Class Not Found");
            }
        }
        [Test]
        public void GivenConstructorNameImproper_WhenAnalyze_ShouldThrowException()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyzer(message);
                object obj = MoodAnalyzerFactory.CreatMoodAnalyzer("MAnalyzer.MoodAnalyzer", "Mood_analyzer");
                expected.Equals(obj);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Constructor Not Found");
            }
        }
    }
}