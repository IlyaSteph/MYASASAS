using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CallCalendar.Data
{
    static class speee
    {
        public static void SaveUserChoose(Che_hoch choose)
        {
            string filename = System.AppDomain.CurrentDomain.BaseDirectory + "/saves/" + choose.date.ToString("dd-MM-yyyy") + ".json";

            if (choose.items.Count == 0)
            {
                if (File.Exists(filename))
                    File.Delete(filename);

                return;
            }

            string json = JsonSerializer.Serialize(choose.items);

            if (!Directory.Exists(filename))
            {
                Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory + "/saves");
            }
            File.WriteAllText(filename, json);
        }

        public static Che_hoch LoadUserChoose(DateOnly date)
        {
            string filename = System.AppDomain.CurrentDomain.BaseDirectory + "/saves/" + date.ToString("dd-MM-yyyy") + ".json";

            Che_hoch choose = new (date);

            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);

                choose.items = JsonSerializer.Deserialize<List<string>>(json) ?? new ();
            }

            return choose;
        }
    }
}