using System.Text.RegularExpressions;
public class Validar
{
internal string cadena ="";

	public virtual bool validarNumero(string cadena)
	{
		this.cadena = cadena;
		Regex checktime =
        new Regex(@"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$");
		if (checktime.IsMatch(cadena))
		{
			return true;
		}
		else
		{
			return false;
		}
	}

		public virtual bool validarDia(string cadena)
		{
		this.cadena = cadena;
		if (new string[] { "MO", "TU", "WE", "TH", "FR", "SA", "SU" }.Contains(cadena))
		{
			return true;
		}
		else
		{
			return false;
		}
		}

}