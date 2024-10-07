using System.Globalization;

DateTime fecha = new DateTime(2024, 1, 8);

CultureInfo cultura = CultureInfo.InvariantCulture;

Calendar calendario = cultura.Calendar;

CalendarWeekRule reglaSemana = cultura.DateTimeFormat.CalendarWeekRule;
DayOfWeek primerDiaSemana = cultura.DateTimeFormat.FirstDayOfWeek;

int numeroSemana = calendario.GetWeekOfYear(fecha, reglaSemana, primerDiaSemana);

Console.WriteLine($"La fecha {fecha.ToShortDateString()} está en la semana número {numeroSemana} del año {fecha.Year}.");


/*
CultureInfo cultura = new CultureInfo("es-EC");


for (DateTime fecha = fechaInicio; fecha <= fechaFin; fecha = fecha.AddDays(1))
{
    int numeroSemana = calendario.GetWeekOfYear(fecha, reglaSemana, primerDiaSemana);
    Console.WriteLine($"Fecha: {fecha.ToShortDateString()} | Semana del año: {numeroSemana}");
}

*/