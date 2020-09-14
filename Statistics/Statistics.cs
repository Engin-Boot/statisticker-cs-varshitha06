using System;
using System.Collections.Generic;
using System.Linq;
using Statistics;


using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers)
        {
            Stats obj = new Stats();
            if (numbers.Count > 0)
            {
                obj.max = numbers.Max<double>();
                obj.min = numbers.Min<double>();
                obj.average = numbers.Average();
            }
            else
            {
                obj.max = double.NaN;
                obj.min = double.NaN;
                obj.average = double.NaN;
            }
            return obj;
        }
    }
}
