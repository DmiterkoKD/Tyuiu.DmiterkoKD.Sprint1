﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DmiterkoKD.Sprint1.Task4.V11.Lib
{
    public class DataService : ISprint1Task4V11
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Atan(x) / Math.Exp(y);
            var res1 = Math.Round(res, 3);
            return res1;
        }
    }
}
