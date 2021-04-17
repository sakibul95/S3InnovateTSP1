using System;
using System.Globalization;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Start date: ");
            DateTime userStartDateTime;
            DateTime userEndDateTime;
            if (DateTime.TryParse(Console.ReadLine(), out userStartDateTime)){}
            Console.WriteLine("Enter End date: ");
            if (DateTime.TryParse(Console.ReadLine(), out userEndDateTime)){}
            var diff = userEndDateTime - userStartDateTime;

            double amount = 0;
            var looplength = Convert.ToString(diff.TotalSeconds / 20);
            string[] a = looplength.Split(new char[] { '.' });
            int decimalsPoint = a[1].Length;
            var looplen = decimalsPoint > 0 ? (Convert.ToInt64(a[0]) + 1) : Convert.ToInt64(a[0]);
            int j = 20;
            for (int i = 1; i <= looplen; i++)
            {
                
                userStartDateTime = userStartDateTime.AddSeconds(20);
                var IsAmPM = userStartDateTime.ToString("tt", CultureInfo.InvariantCulture);
                if (IsAmPM.ToLower() == "am")
                {
                    if ((userStartDateTime.Hour == 12 && userStartDateTime.Minute == 0 && userStartDateTime.Second == 0) || (userStartDateTime.Hour < 9))
                    {
                        amount = amount + 20;
                    }
                    else
                    {
                        amount = amount + 30;
                    }
                }
                else
                {
                    if ((userStartDateTime.Hour == 11 && userStartDateTime.Minute == 0 && userStartDateTime.Second == 0) || (userStartDateTime.Hour < 12))
                    {
                        amount = amount + 20;
                    }
                    else
                    {
                        amount = amount + 30;
                    }
                }
                j = j + 20;
            }

            Console.WriteLine("result = {0} taka",amount/100);

        }
    }
}
