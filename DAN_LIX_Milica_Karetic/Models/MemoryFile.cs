using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_LIX_Milica_Karetic.Models
{
    class MemoryFile
    {
        /// <summary>
        /// The file location we are writing to
        /// </summary>
        private readonly string LocationFile = @"../../TextFile";

        /// <summary>
        /// Write win to file
        /// </summary>
        public void WriteToFile(TimeSpan time)
        {
            // Create directory if it does not exist
            Directory.CreateDirectory(LocationFile);
            StreamWriter sw = new StreamWriter(LocationFile + @"/IgraPamcenja.txt", append: true);
            using (sw)
            {
                sw.WriteLine($"Date and time: {DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}, Total time: {time}");
            }
        }
    }
}
