using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    public class ElectricGuitar
    {
        public void PlugAndStartPlaying()
        {
            Console.WriteLine("Electric Guitar was plugged and is being played");
        }
        public void StopPlaying()
        {
            Console.WriteLine("Playing the Electric Guitar has stopped...");
        }
        public void Unplug()
        {
            Console.WriteLine("Electric Guitar was unplugged");
        }
    }
}
