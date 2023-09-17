using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int hours, day, month, year;
    string firstName, lastName;
    decimal salary, comission, sales, hourValue, baseV;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());


    Console.Write("Ingresar nombre completo: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar salario devengado: ");
    salary = Decimal.Parse(Console.ReadLine());

    Console.Write("Ingresar las ventas generadas: ");
    sales = Decimal.Parse(Console.ReadLine());

    //HardCoding = Quemar Código

    SalaryEmployee SalaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,    
        IsActive = true,    
        Salary = salary,
    };

    Console.WriteLine($"Hourly Employee {SalaryEmployee.ToString()}");
    Console.WriteLine("\n");

//----------------------------------------------------------------------

    Console.Write("Ingrese el porcetaje de comision: ");
    comission = Decimal.Parse(Console.ReadLine());

    Console.Write("Ingrese el valor de venta: ");
    sales = Decimal.Parse(Console.ReadLine());

    CommissionEmployee comissionEmployee = new CommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = sales,
        CommisionPercentaje = comission,
    };

    Console.WriteLine($"Commission Employee {comissionEmployee.ToString()}");
    Console.WriteLine("\n");
    //----------------------------------------------------------------------

    Console.Write("Ingrese las horas laboradas: ");
    hours = Int32.Parse(Console.ReadLine());

    Console.Write("Ingresar valor por hora: ");
    hourValue = Decimal.Parse(Console.ReadLine());

    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        HourValue = hourValue,
        Hours = hours,
    };

    Console.WriteLine($"Hourly Employee {hourlyEmployee.ToString()}");
    Console.WriteLine("\n");


    //-------------------------------------------------------------

    Console.Write("Ingresar pago base: ");
    baseV = Decimal.Parse(Console.ReadLine());

    BaseCommissionEmployee baseComissionEmployee = new BaseCommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = sales,
        CommisionPercentaje = comission,
        Base = baseV,
    };

    Console.WriteLine($"Base Commision Employee {baseComissionEmployee.ToString()}");
    Console.WriteLine("\n");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}