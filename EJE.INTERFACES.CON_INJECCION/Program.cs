using EJE.INTERFACES.CON_INJECCION;
using static System.Net.Mime.MediaTypeNames;

static void Main()
{
    IOperacion operacion = new Suma();
    //Application.Run(new Form1(operacion));
}