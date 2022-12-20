
var Constructor = new Employee(1, " Shahrom ", " Sharipov ", 100);

System.Console.Write(" ID : ");
System.Console.WriteLine(Constructor.GetId());
System.Console.Write(" FirstName : ");
System.Console.WriteLine(Constructor.GetfirstName());
System.Console.Write(" LastName : ");
System.Console.WriteLine(Constructor.GetLastName());
System.Console.Write(" GetName : ");
System.Console.WriteLine(Constructor.GetName());
System.Console.Write(" GetSalary : ");
System.Console.WriteLine(Constructor.GetSalary());

Constructor.SetSalary(20);

System.Console.Write( " GetAnnualSalary : " );
System.Console.WriteLine(Constructor.GetAnnualSalary());

System.Console.Write(" Raise Salary : ");
System.Console.WriteLine(Constructor.RaiseSalary());

System.Console.Write( " ToString : " );
System.Console.Write(Constructor.Tostring());

