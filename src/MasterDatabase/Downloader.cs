using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MasterDatabase
{
    class Downloader
    {
        public void Execute()
        {
            string[] pgns = new string[]
            {
                "Alexander%20Alekhine.pgn",
                "Alexi%20Shirov.pgn",
                "Anatoly%20Karpov.pgn",
                "Bobby%20Fischer.pgn",
                "Boris%20Spassky.pgn",
                "Deep%20Blue%20vs%20Kasparov%201996%20(Game%201).pgn",
                "Deep%20Fritz%20-%20Kramnik%20(Game%202).pgn",
                "Dortmund%20Chess.pgn",
                "Game%20of%20the%20Century.pgn",
                "Garry%20Kasparov.pgn",
                "Hikaru%20Nakamura.pgn",
                "Hou%20Yifan.pgn",
                "Jose%20Raul%20Capablanca.pgn",
                "Kasparov%20vs%20the%20World.pgn",
                "Levon%20Aronian.pgn",
                "Magnus%20Carlsen.pgn",
                "Magnus%20Carlsen___.pgn",
                "Max%20Euwe.pgn",
                "Michael%20Adams.pgn",
                "Mikhail%20Tal.pgn",
                "Peter%20Leko.pgn",
                "Sergey%20Karjakin.pgn",
                "Tal%20Memorial.pgn",
                "Tata%20Chess.pgn",
                "Viktor%20Korchnoi.pgn",
                "Viswanathan%20Anand.pgn",
                "Vladimir%20Kramnik.pgn",
                "World%20Championship.pgn",
            };
            HttpClient c = new HttpClient();
            using (FileStream fs = File.Create("output.pgn"))
            {
                foreach (var pgn in pgns)
                {
                    bool rerun = false;
                    for (int i = 0; i < 3; i++)
                    {
                        byte[] bytes;
                        try
                        {

                            bytes = c.GetByteArrayAsync("http://smallchess.com/Games/" + pgn).Result;
                            fs.Write(bytes, 0, bytes.Length);
                            rerun = false;
                        }
                        catch (Exception)
                        {
                            rerun = true;
                        }
                        if (!rerun)
                            break;
                    }

                }
            }
        }
    }
}
