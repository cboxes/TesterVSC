// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using ProjectChallenge;
class Program
{
public static void Main(string[] args)
		{
			String file = @"files/file_hour.txt"; //directory de almacenamiento de archivo txt, puede modificarlo según su propia ruta
			if(File.Exists(file)){
				Empleados[] Empleado = PagoEmpleado.txtExtraeArchivo(file); //Extrae cada empleado del archivo a un arreglo
				new CalculaPago(Empleado,0.00);                //Calcula el pago de cada empleado
			} else{
				Console.WriteLine("Archivo no existe.");
			}

		}
}