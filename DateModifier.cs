using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class DateModifier
    {
        public int difference { get; set; }

        public void CalculateDifference(string firstDate, string secondDate)
        {
            int[] firstDateList = firstDate.Split().Select(int.Parse).ToArray();
            int[] secondDateList = secondDate.Split().Select(int.Parse).ToArray();
            int firstYear = firstDateList[0];
            int firstMonth = firstDateList[1];
            int firstDay = firstDateList[2];
            int secondYear = secondDateList[0];
            int secondMonth = secondDateList[1];
            int secondDay = secondDateList[2];

            DateTime firstDateObj = new DateTime(firstYear, firstMonth, firstDay);
            DateTime secondDateObj = new DateTime(secondYear, secondMonth, secondDay);

            difference = Math.Abs((secondDateObj.Date - firstDateObj.Date).Days);
            Console.WriteLine(difference);
        }
    }
}
