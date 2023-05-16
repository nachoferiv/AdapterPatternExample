using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    public class ElectricGuitarAdapter : Guitar
    {
        ElectricGuitar electricGuitar = new ElectricGuitar();

        public void StartPlaying()
        {
            this.electricGuitar.PlugAndStartPlaying();
        }

        public void StopPlaying()
        {
            this.electricGuitar.StopPlaying();
            this.electricGuitar.Unplug();
        }
    }
}
