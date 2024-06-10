using NUnit.Framework;

namespace Spiratec.IOSEF.Editor.Test
{
    public class TestMath
    {    
        [Test]
        [TestCase(0F, 0F, ExpectedResult = 0F)]
        [TestCase(1F, 1F, ExpectedResult = 2F)]
        [TestCase(2, 2F, ExpectedResult = 4F)]
        public float TestMathAdd(float a, float b)
        {
            return 1;
        }
    }
}


