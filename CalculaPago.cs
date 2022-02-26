using System;


public class CalculaPago
{
	internal double valorHoraT;


public CalculaPago(Empleados[] Empleado, double valorHoraT)
{
	this.valorHoraT = valorHoraT;
	DateTime dHoraI;
	DateTime dHoraF;
	double valorHora = 0.00;

	String sNombrex = Empleado[0].nombre;
	try
	{
	   for (int i = 0; i < Empleado.Length; i++)
	   {
		string sNombre = Empleado[i].nombre;
		string sDia = Empleado[i].dia;
		dHoraI = Empleado[i].horai;
		dHoraF = Empleado[i].horaf;

		if (!string.ReferenceEquals(sNombre, sNombrex))
		{
		   Console.WriteLine("The amount to pay " + sNombrex + " is: " + valorHora + " USD");
		   valorHoraT = valorHora;
		   sNombrex = sNombre;
		   valorHora = 0.00;
		}
		valorHora = valorHora +  dRangoHoras(sDia,dHoraI,dHoraF);
	   }
	   Console.WriteLine("The amount to pay " + sNombrex + " is: " + valorHora + " USD");
	}
	catch (Exception e)
	{
			Console.WriteLine(e.ToString());
			Console.Write(e.StackTrace);
	}
}

public virtual double dRangoHoras(string dia, DateTime horai , DateTime horaf)
{
	DateTime dHor1I = DateTime.Parse("00:01");
	DateTime dHor1F = DateTime.Parse("09:00");
	DateTime dHor2I = DateTime.Parse("09:01");
	DateTime dHor2F = DateTime.Parse("18:00");
	DateTime dHor3I = DateTime.Parse("18:01");
	DateTime dHor3F = DateTime.Parse("00:00");
	double valorHora = 0.00;


	switch (dia)
	{
			case "MO" or "TU" or "WE" or "TH" or "FR" :
			if ((DateTime.Compare(horai,dHor1I) >= 0) && (DateTime.Compare(horai,dHor1F) <= 0) &&
                (DateTime.Compare(horaf,dHor1I) >= 0) && (DateTime.Compare(horaf,dHor1F) <= 0)
            )				
				{valorHora = 25.00;}
			else if	  								
			((DateTime.Compare(horai,dHor2I) >= 0) && (DateTime.Compare(horai,dHor2F) <= 0) &&
             (DateTime.Compare(horaf,dHor2I) >= 0) && (DateTime.Compare(horaf,dHor2F) <= 0)
            )
				{valorHora = 15.00; }
	        else if 
			((DateTime.Compare(horai,dHor3I) >= 0) && (DateTime.Compare(horai,dHor3F) >= 0) &&
             (DateTime.Compare(horaf,dHor3I) >= 0) && (DateTime.Compare(horaf,dHor3F) >= 0)
                           )
				{valorHora = 20.00;}
			break;
			case "SA" or "SU" :
			if ((DateTime.Compare(horai,dHor1I) >= 0) && (DateTime.Compare(horai,dHor1F) <= 0) &&
                (DateTime.Compare(horaf,dHor1I) >= 0) && (DateTime.Compare(horaf,dHor1F) <= 0)
            )
				{valorHora = 30.00;}
			else if 
			((DateTime.Compare(horai,dHor2I) >= 0) && (DateTime.Compare(horai,dHor2F) <= 0) &&
             (DateTime.Compare(horaf,dHor2I) >= 0) && (DateTime.Compare(horaf,dHor2F) <= 0)
			)	
				{valorHora = 20.00;}
	        else if 
			((DateTime.Compare(horai,dHor3I) >= 0) && (DateTime.Compare(horai,dHor3F) >= 0) &&
             (DateTime.Compare(horaf,dHor3I) >= 0) && (DateTime.Compare(horaf,dHor3F) >= 0)
            )
				{valorHora = 25.00;}
			break;
	    	
			default: break;
	}

	return valorHora;
	}
}