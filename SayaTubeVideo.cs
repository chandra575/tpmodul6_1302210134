using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210134
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string videoTitle)
        {
            
            if (videoTitle == null || videoTitle.Length > 100)
            {
                throw new ArgumentException("Judul video harus berisi antara 1-100 karakter");
            }

            Random rand = new Random();
            id = rand.Next(10000, 99999);
            title = videoTitle;
            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 10000000)
            {
                throw new ArgumentOutOfRangeException("Jumlah penambahan play count harus di antara 0-10.000.000");
            }

            try
            {
                playCount = checked(playCount + count);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("================================= Video Details =================================");
            Console.WriteLine("ID           : " + id);
            Console.WriteLine("Judul        : " + title);
            Console.WriteLine("Play Count   : " + playCount);
            Console.WriteLine("=================================================================================");
        }
    }
}
