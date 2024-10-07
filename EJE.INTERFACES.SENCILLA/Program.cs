public interface IOperacion
{
    void Calcular();
}

public class Suma : IOperacion
{
    public void Calcular()
    {
        // Lógica de suma
        Console.WriteLine("Calculando suma...");
    }
}

public class Resta : IOperacion
{
    public void Calcular()
    {
        // Lógica de resta
        Console.WriteLine("Calculando resta...");
    }
}

/*

ESTE SERIA EL EJEMPLO EN CLICK DEL BOTON COMO PODER IMPLEMENTALA SIN TENER QUE SUAMAR INJECCIONES DE DEPENDICIA 


private void btnCalcular_Click(object sender, EventArgs e)
{
    IOperacion operacion = new Suma(); // Aquí puedes usar polimorfismo
    operacion.Calcular();
}
*/