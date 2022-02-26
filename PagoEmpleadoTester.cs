using Xunit;
using ProjectChallenge;

namespace UnitTestEmp
{	
	public class PagoEmpleadoTester
	{

		[Fact]
		public void TestValidarDiasPass()
		{
			//Arrange
			Validar valida = new Validar();
			String dia = "MO";
			//Act
			bool isValid =  valida.validarDia(dia);
			//Assert
			Assert.True(isValid);
		}
		[Fact]
		public void TestValidarDiasFail()
		{
			//Arrange
			Validar valida = new Validar();
			String dia = "MT";
			//Act
			bool isValid =  valida.validarDia(dia);
			//Assert
			Assert.False(isValid);
		}

		[Fact]
		public void TestValidarHoraPass1()
		{
			//Arrange
			Validar valida = new Validar();
			String hora ="10:00";
			//Act
			bool isValid =  valida.validarNumero(hora);
			//Assert
			Assert.True(isValid);

		}
		[Fact]
		public void TestValidarHoraPass2()
		{
			//Arrange
			Validar valida = new Validar();
			String hora ="10:.0";
			//Act
			bool isValid =  valida.validarNumero(hora);
			//Assert
			Assert.False(isValid);

		}

		[Fact]
		public void TestValidarHoraPass3()
		{
			//Arrange
			Validar valida = new Validar();
			String hora ="10-00";
			//Act
			bool isValid =  valida.validarNumero(hora);
			//Assert
			Assert.False(isValid);

		}
		[Fact]
		public void TestCalculaPago()
		{
			//Arrange
			//Creates a list of hours to be added to the employee
			Empleados[] Empleado = new Empleados[2];
			DateTime dHoraI = DateTime.Parse("09:00"); //hora inicial
			DateTime dHoraF = DateTime.Parse("12:00"); //hora final
			Empleado[0] = new Empleados("LEO","MO", dHoraI,dHoraF);
			DateTime dHora1I = DateTime.Parse("10:00"); //hora inicial
			DateTime dHora1F = DateTime.Parse("17:00"); //hora final
			Empleado[1] = new Empleados("PAT","SA", dHora1I,dHora1F);	
			//Act
			CalculaPago calculapago = new CalculaPago(Empleado,0.00);
			//Assert
			
			Assert.NotNull(Empleado);

		}
	}
}