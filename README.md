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

  The most up-to-date documentation can be found at https://github.com/cboxes/TesterC-.git.


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

   Download the package from the url:
   On your local computer create a folder of your choice. Example c:\Solution
   Inside this created folder copy the downloaded files.
   Go to windows explorer and type "cmd" to open a command prompt.
   1) Compile the java files as follows:
     C:\Solucion>javac Validar.java CalculaPago.java Empleados.java PagoEmpleado.java PagoEmpleadoTester.java
     and then press <Enter>.
   2) Run the following:
      java PagoEmpleado

   C:\Solucion>java PagoEmpleado
   The amount to pay RENE is: 100.0 USD
   The amount to pay ASTRID is: 60.0 USD
   The amount to pay SAUL is: 85.0 USD
   The amount to pay BRAT is: 105.0 USD
   The amount to pay MICTHE is: 60.0 USD

   Unit tests
   -----------------
   In this example, we've created a mock of CalculaPago to get the dummy pay of some employees and unit tested a java class named PagoEmpleado.
  
   Step 1 - Test the PagoEmpleado class.
   Let's test the PagoEmpleado class, by injecting in it a mock of CalculoPago. Mock will be created by Mockito.
   
   Step 2 − Verify the result
   Now run the PagoEmpleadoTester to see the result:
 
   C:\Solucion>java --add-opens java.base/java.lang=ALL-UNNAMED PagoEmpleadoTester
  
   Verify the Output
   
   pass
