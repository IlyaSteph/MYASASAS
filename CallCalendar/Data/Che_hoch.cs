using System;
using System.Collections.Generic;

namespace CallCalendar
{
    public class Che_hoch
    {
        public readonly static string[] options =
        {
            "money", "visa", "lom", "наручни))", "тюрьм))))))", "master"
        };

        public Che_hoch(DateOnly date)
        {
            this.date = date;
        }/// <summary>
        //
        /// </summary>

        public DateOnly date { get; init; }
        public List<string> items = new ();
    }
}
///
///

