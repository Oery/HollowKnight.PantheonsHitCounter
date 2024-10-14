using System;
using System.IO;

namespace PantheonsHitCounter
{
    public class Spreadsheet
    {
        private static readonly string PantheonsStatsSpreadsheetPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/PantheonsHitStats.csv";

        public static void InsertRow(int index, int pantheon, string bossName, int hitsTaken, int win, int killedRun, DateTime time)
        {
            using (StreamWriter writer = new StreamWriter(PantheonsStatsSpreadsheetPath, true))
            {
                string formattedDateTime = time.ToString("yyyy-MM-dd HH:mm:ss");

                string newRow = $"{index},P{pantheon},{bossName},{hitsTaken},{win},{killedRun},{formattedDateTime}";
                writer.WriteLine(newRow);
            }
        }
    }
}
