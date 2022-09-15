using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateModifier {
    public class DateModifier {
        public int DaysDifference(string firstDate, string secondDate) {
            int[] currentDate = firstDate.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            DateTime date1 = new DateTime(currentDate[0], currentDate[1], currentDate[2]);

            currentDate = secondDate.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            DateTime date2 = new DateTime(currentDate[0], currentDate[1], currentDate[2]);

            return Math.Abs((date1 - date2).Days);
        }
    }
}
