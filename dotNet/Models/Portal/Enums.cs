using System;
using System.Collections.Generic;
using System.Linq;

namespace LottoGistAdmin.Models.Portal
{



    public enum WeekDayEnum
    {
        Monday = 1, Tuesday, Wednesday, Thurday, Friday, Saturday, Sunday
    }

    public enum ChartItemType
    {
        None = 0,
        Calculation = 1,
        Reading_Plan,
        Working_Plan,
        Best_Pairs,
        Special_Perm,
        Events_To_Watch
    }
    public class KeyValuePair
    {
        public string Name { get; set; }

        public int Id { get; set; }    
    }

    public static class EnumManager
    {
        public static List<KeyValuePair> ConvertEnumToList<T>()
        {
            var array = (T[])(Enum.GetValues(typeof(T)).Cast<T>());
            return array
                .Select(a => new KeyValuePair
                {                 
                    Name = a.ToString(),//.SplitCapitalizedWords(),
                    Id = Convert.ToInt32(a)
                })
                .OrderBy(kvp => kvp.Name)
                .ToList();
        }
    }
}
