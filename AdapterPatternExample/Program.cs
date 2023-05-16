using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicGuitar classicGuitar = new ClassicGuitar();
            AcousticGuitar acousticGuitar = new AcousticGuitar();
            ElectricGuitarAdapter electricGuitar = new ElectricGuitarAdapter();
            classicGuitar.StartPlaying();
            classicGuitar.StopPlaying();

            acousticGuitar.StartPlaying();
            acousticGuitar.StopPlaying();

            electricGuitar.StartPlaying();
            electricGuitar.StopPlaying();

            Console.ReadKey();
        }
    }
}
