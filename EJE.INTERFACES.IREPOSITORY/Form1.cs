using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE.INTERFACES.IREPOSITORY
{
    internal class Form1 /*: Form*/
    {
        private readonly IRepository<Operacion> _operacionRepository;

        public Form1(IRepository<Operacion> operacionRepository)
        {
            //InitializeComponent();
            _operacionRepository = operacionRepository;
        }


        // Evento del botón para agregar una nueva operación
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevaOperacion = new Operacion { Id = 1, Nombre = "Suma" };
            _operacionRepository.Add(nuevaOperacion);
            //MessageBox.Show("Operación agregada: " + nuevaOperacion.Nombre);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var operaciones = _operacionRepository.GetAll();
            foreach (var operacion in operaciones)
            {
                //MessageBox.Show("Operación: " + operacion.Nombre);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var operacionActualizada = new Operacion { Id = 1, Nombre = "Suma Actualizada" };
            _operacionRepository.Update(operacionActualizada);
            //MessageBox.Show("Operación actualizada: " + operacionActualizada.Nombre);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _operacionRepository.Delete(1);
            //MessageBox.Show("Operación eliminada");
        }

    }
}
