PagoEmpleado

  What is it?
  -----------

  Employee Payment allows you to calculate the total that the company must pay an employee, based on the hours
  worked and the times during which she worked. The solution is developed in java language.
  The following abbreviations will be used for data entry:
  MO: Monday
  TU: Tuesday
  WE: Wednesday
  TH: Thursday
  FR: Friday
  SA: Saturday
  SU: Sunday
  The entry is the name of an employee and the schedule they worked, indicating the time and hours. This must be a
   .txt file with at least five data sets. An example file is attached and can be used to test the program.

  The text file is called file_hour.txt. The entire exercise must be run in the same directory where it is downloaded
  the solution from github.

  The solution validates that the data is entered in the following format:
  ASTRID=MO10:00-12:00,TH12:00-14:00,SU20:00-21:00

  In the case of not being with the indicated format, the program will indicate which line will not be processed for 
  the calculation:
    Payment for each employee.
    It also validates that the hours are numbers.

   Architecture
   ------------
   PagoEmpleados.csproj: Project.
   PagoEmpleado.cs: Where the process starts.
   PagoEmpleadoTester.cs: Allows you to perform unit tests.
   Empleados.cs: To instantiate each employee and his attributes.
   Validar.cs : Validates that abbreviations and input data formats are respected from the txt file.
   CalculaPago.cs: Allows the calculation of the total payments for each employee based on the schedules.
   Arrays.cs: This class is used to replace some calls to Arrays methods with the C# equivalent.
   Program.cs: It is the main program.
    

   Object-oriented development is focused and under the xp methodology (it allows to have fewer lines of code and tests
   unitary).

  Documentation
  -------------

  The most up-to-date documentation can be found at https://github.com/cboxes/TesterVSC.git.


  System Requirements
  -------------------

  .Net Core SDK:
    https://dotnet.microsoft.com/en-us/download.
  Memory:
    No minimum requirement.
  Operating System:
    Windows:
      Windows 10 or above.
      No minimum requirement.


   Run the program
   --------------------
   In Windows press Windows key + R, then type “cmd” and press enter.
   Run the following command line:
        C:>dotnet new console -o PagoEmpleados
   This will create the template with the necessary files for a C# program.
   Download the package from the url: https://github.com/cboxes/TesterVSC and copy it to the folder PagoEmpleados.
   Change to the PagoEmpleados folder and run the command:
        C:\PagoEmpleados>dotnet build
   Now run the command: 
        C:\PagoEmpleados>dotnet run

   The amount to pay RENE is: 100 USD
   The amount to pay ASTRID is: 60 USD
   The amount to pay SAUL is: 85 USD
   The amount to pay BRAT is: 105 USD
   The amount to pay MICTHE is: 60 USD
   The amount to pay ROB is: 85 USD

   Unit tests
   -----------------
   In the example, unit tests will be used with xunit on the CalculaPago class.
  
   Run the command: C:\PagoEmpleados>dotnet test
  
   Iniciando la ejecución de pruebas, espere...
   1 archivos de prueba en total coincidieron con el patrón especificado.

   Correctas! - Con error:     0, Superado:     6, Omitido:     0, Total:     6, Duración: 6 ms - PagoEmpleados.dll (net6.0)
   
