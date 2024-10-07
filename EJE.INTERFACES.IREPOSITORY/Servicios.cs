using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE.INTERFACES.IREPOSITORY
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(int id);
    }

    public class Operacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class OperacionRepository : IRepository<Operacion>
    {
        private List<Operacion> _operaciones = new List<Operacion>();

        public void Add(Operacion entity)
        {
            _operaciones.Add(entity);
        }

        public Operacion GetById(int id)
        {
            return _operaciones.FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<Operacion> GetAll()
        {
            return _operaciones;
        }

        public void Update(Operacion entity)
        {
            var operacion = GetById(entity.Id);
            if (operacion != null)
            {
                operacion.Nombre = entity.Nombre;
            }
        }

        public void Delete(int id)
        {
            var operacion = GetById(id);
            if (operacion != null)
            {
                _operaciones.Remove(operacion);
            }
        }
    }
}
