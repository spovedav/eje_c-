using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE.SEMANA.RANGO
{
    public class SemanaHelper
    {
        public static (DateTime inicioSemana, DateTime finSemana) ObtenerRangoSemana(DateTime fecha)
        {
            // Obtener el día de la semana de la fecha proporcionada
            DayOfWeek diaSemana = fecha.DayOfWeek;

            // Calcular la diferencia de días para encontrar el lunes (o el primer día de la semana)
            int diferenciaConLunes = ((int)diaSemana - (int)DayOfWeek.Monday + 7) % 7;

            // Restar la diferencia para obtener el primer día de la semana (Lunes)
            DateTime inicioSemana = fecha.AddDays(-diferenciaConLunes);

            // El final de la semana será 6 días después del inicio
            DateTime finSemana = inicioSemana.AddDays(6);

            return (inicioSemana, finSemana);
        }
    }
}
