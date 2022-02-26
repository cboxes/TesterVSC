// Empleados son retornados en un arreglo
public class Empleados
{

	internal string nombre;
	internal string dia;
	internal DateTime horai;
	internal DateTime horaf;


	// Constructor a instanciar clase..
	public Empleados(string nombre, string dia, DateTime horai, DateTime horaf)
	{
		this.nombre = nombre;
		this.dia = dia;
		this.horai = horai;
		this.horaf = horaf;
	}
}