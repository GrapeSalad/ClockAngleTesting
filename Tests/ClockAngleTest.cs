using Xunit;
using System;

namespace ClockAngle
{
  public class TestClockAngleCalc
  {
    [Fact]
    public void TestInputType()
    {
      // int number = 0;
      Console.WriteLine(typeof(int));
      DetermineAngle typeTest = new DetermineAngle();
      Assert.Equal(typeof(int), typeTest.GetDegree(2, 15).GetType());
    }

    [Fact]
    public void TestInputAngle()
    {
      DetermineAngle angleTest = new DetermineAngle();
      Assert.Equal(30, angleTest.GetDegree(2, 15));
    }

    [Fact]
    public void TestForLargeAngle()
    {
      DetermineAngle angleTest = new DetermineAngle();
      Assert.Equal(180, angleTest.GetDegree(3, 45));

    }
  }
}
