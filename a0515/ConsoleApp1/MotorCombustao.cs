using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MotorCombustao : IMotor
    {
        public double combustivel;
        public bool ligado;
        public void Deligar()
        {
            if (ligado)
                ligado = false;

            Console.WriteLine("Motor combustao desligado!");
        }

        public void Ligar()
        {
            if (combustivel > 0 && !ligado)
            {
                ligado = true;
            }
            Console.WriteLine("Motor combustao ligado!");
        }
    }
}
