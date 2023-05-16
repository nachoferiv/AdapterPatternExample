using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    public class ClassicGuitar : Guitar
    {
        public void StartPlaying()
        {
            Console.WriteLine("Playing the Acousting Guitar...");
        }

        public void StopPlaying()
        {
            Console.WriteLine("Playing the Acousting Guitar has stopped...");
        }
    }
}
