using System;
using System.IO;

namespace ProjectChallenge
{
	public class PagoEmpleado
	{
		public static Empleados[] txtExtraeArchivo(String file)
		{
		Empleados[] Empleado = new Empleados[100];
		int LineaNum = 0;
		
		Validar dato = new Validar();
			try
			{
				
				foreach (string line in System.IO.File.ReadLines(file))
				{  
					string[] part1 = line.Split("=");
					string[] part2 = part1[1].Split(",");
					string sNombre = part1[0]; //Nombre de empleado				  
					for (int i = 0; i < part2.Length; i++)
					{
						// en cada iteración obtiene dias y horas trabajadas del arreglo part2
						string sDia = part2[i].Substring(0, 2); // dia de trabajo
						//obtener las horas de trabajo
						int part2long = part2[i].Length;
						string[] part3 = part2[i].Substring(2, part2long - 2).Split("-");
						try
						{
							if (dato.validarNumero(part3[0]) && dato.validarNumero(part3[1]) && dato.validarDia(sDia)) //Validar los datos del archivo segun formato
							{
								DateTime dHoraI = DateTime.Parse(part3[0]); //hora inicial
								DateTime dHoraF = DateTime.Parse(part3[1]); //hora final
								Empleado[LineaNum] = new Empleados(sNombre,sDia,dHoraI,dHoraF);
							}
							else
							{
								DateTime dHoraI = DateTime.Parse("00:00"); //hora inicial
								DateTime dHoraF = DateTime.Parse("00:00"); //hora final
								Empleado[LineaNum] = new Empleados(sNombre,sDia,dHoraI,dHoraF);
								Console.WriteLine("El empleado " + sNombre + " contiene un dia y/o una hora no valida : => " + sDia + part3[0] + "-" + part3[1] + " que NO se ingresa al calculo");
							}
						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
							Console.Write(e.StackTrace);
						}
				LineaNum++;
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
			Empleados[] EmpleadoNew =  Arrays.CopyOf(Empleado, LineaNum);
			return EmpleadoNew;
		}	
	}
}