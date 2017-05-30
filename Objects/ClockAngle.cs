using System;

namespace ClockAngle
{
  public class DetermineAngle
  {
    int minuteDegree = 6;
    int hourDegree = 30;

    // public int minute;
    // public int hour;
    //
    public int GetDegree(int hour, int minute)
    {
      int degree = Math.Abs((hour * hourDegree) - (minute * minuteDegree));
      // if (degree > 180)
      // {
      //   return 360 - degree;
      // }
      // else{
        return degree;
      // }
    }
  }
}
