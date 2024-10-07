using System.Globalization;

static bool HasWeek53(int year)
{
    // Obtener el último día del año
    DateTime lastDayOfYear = new DateTime(year, 12, 31);

    // Obtener el número de semana del último día del año
    // Utiliza la cultura ISO 8601, que comienza la semana el lunes
    CultureInfo cul = CultureInfo.CurrentCulture;
    Calendar cal = cul.Calendar;

    // La semana 53 existe si el 31 de diciembre cae en jueves o si es miércoles en un año bisiesto
    int lastWeek = cal.GetWeekOfYear(lastDayOfYear, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

    return lastWeek == 53;
}

int year = 2024; // Puedes cambiar el año para probar
bool hasWeek53 = HasWeek53(year);
Console.WriteLine($"¿El año {year} tiene semana 53? {hasWeek53}");