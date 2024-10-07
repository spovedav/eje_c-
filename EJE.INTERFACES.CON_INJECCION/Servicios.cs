using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE.INTERFACES.CON_INJECCION
{
    public interface IOperacion
    {
        void Calcular();
    }

    public class Suma : IOperacion
    {
        public void Calcular()
        {
            Console.WriteLine("Calculando suma...");
        }
    }

    public class Resta : IOperacion
    {
        public void Calcular()
        {
            Console.WriteLine("Calculando resta...");
        }
    }
}
