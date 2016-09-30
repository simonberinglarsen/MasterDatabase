using System.IO;

namespace MasterDatabase
{
    class Extractor
    {
        public void Execute()
        {
            string text = File.ReadAllText(".\\output.pgn");
            string[] ecos = new[]
            {
                "B10",
                "B11",
                "B12",
                "B13",
                "B14",
                "B15",
                "B16",
                "B17",
                "B18",
                "B19",
            };

        }
    }
}