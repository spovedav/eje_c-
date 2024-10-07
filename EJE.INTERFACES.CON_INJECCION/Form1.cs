using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE.INTERFACES.CON_INJECCION
{
    internal class Form1 /*: Form*/
    {
        private readonly IOperacion _operacion;

        public Form1(IOperacion operacion)
        {
            //InitializeComponent();
            _operacion = operacion;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            _operacion.Calcular();
        }

        private void btnOtraOperacion_Click(object sender, EventArgs e)
        {
            _operacion.Calcular();
        }
    }
}
