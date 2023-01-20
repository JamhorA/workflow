using TestProject1.Components;
using Xunit;
using Xunit.Abstractions;

namespace TestProject1.Test
{
    public class DiceTestes
    {
        private readonly ITestOutputHelper _testOutputHelper;
        public DiceTestes(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ThrowDiceTest()
        {
            bool boolRes = false;
            var myDice = new Dice();
            int result = myDice.throwDice();
            _testOutputHelper.WriteLine(result.ToString());
            if(result < 7 && result > 0)
                boolRes= true;
            Assert.True(boolRes);

        }
       
    }
}