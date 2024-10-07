
DateTime fechaInicio = new DateTime(2024, 10, 1);
DateTime fechaFin = new DateTime(2024, 10, 31);

for (DateTime fecha = fechaInicio; fecha <= fechaFin; fecha = fecha.AddDays(1))
{
    string diaMes = fecha.ToString("dd");
    string diaSemana = fecha.ToString("dddd");

    Console.WriteLine($"Fecha: {fecha.ToShortDateString()} | Día del mes: {diaMes} | Día de la semana: {diaSemana}");
}
