using System.IO;

namespace PantheonsHitCounter
{
    public class Spreadsheet
    {
        private static readonly string PantheonsStatsSpreadsheetPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/PantheonsHitStats.csv";

        public static void InsertRow(int pantheon, string bossName, int hitsTaken, int win, int killedRun)
        {
            using (StreamWriter writer = new StreamWriter(PantheonsStatsSpreadsheetPath, true))
            {
                string newRow = $"RUNX,P{pantheon},{bossName},{hitsTaken},{win},{killedRun}";
                writer.WriteLine(newRow);
            }
        }
    }
}
