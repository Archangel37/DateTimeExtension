using System;
using System.Collections.Generic;
using System.Globalization;

namespace YieldDateTime
{
    /// <summary>
    ///     Статический класс для расширения методов DateTime
    /// </summary>
    static class DateTimeExtension
    {
        /// <summary>
        ///     Необходимая функция "Взятия" нескольких дней до или после текущей даты
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        public static IEnumerable<DateTime> TakeDays(this DateTime dt, int days)
        {
            if (days > 0)
                for (int i = 1; i <= days; i++)
                {
                    yield return dt.AddDays(i);
                }
            else if (days < 0)
                for (int i = -1; i >= days; i--)
                {
                    yield return dt.AddDays(i);
                }
            else yield break;
        }

        /// <summary>
        ///     Превод "в человеческий" вид даты: содержит дату, день недели, день в году этой даты и номер недели
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToHumanView(this DateTime dt) => 
            $"{dt.ToString("D")} " +
            $"({CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(dt.DayOfWeek)}) - " +
            $"{dt.DayOfYear}-й день в году, номер недели: {dt.WeekInYear()}";

        /// <summary>
        ///     Возвращает номер недели в году, к которому относится дата, недели начинаются с понедельника
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static int WeekInYear(this DateTime dt) =>
        new GregorianCalendar().GetWeekOfYear(dt, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);  
    }
}
