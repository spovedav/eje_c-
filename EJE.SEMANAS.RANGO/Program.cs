// Proporcionamos una fecha, en este caso, el 02/01/2024
using EJE.SEMANA.RANGO;

DateTime fecha = new DateTime(2024, 1, 2);

// Obtener el rango de fechas para la semana de esa fecha
var (inicio, fin) = SemanaHelper.ObtenerRangoSemana(fecha);

// Mostrar los resultados
Console.WriteLine($"La semana de la fecha {fecha.ToShortDateString()} va desde {inicio.ToShortDateString()} hasta {fin.ToShortDateString()}.");