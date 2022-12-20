public class Employee
{
    private int _id;
    private string _firstName;
    private string _lastName;
    private int _salary;
     public Employee(int id, string firstName, string lastName, int salary )
     {
        _id = id;
        _firstName = firstName;
        _lastName = lastName;
        _salary = salary;
     }
     public int GetId()
     {
      return _id;
     }
     public string GetfirstName()
     {
        return _firstName;
     }
     public string GetLastName()
     {
        return _lastName;
     }
     public string GetName()
     {
        return _firstName + "" +_lastName;
     }
     public int GetSalary()
     {
        return _salary;
     }
     public void SetSalary(int salary)
     {
        _salary = salary;  
     }
     public int GetAnnualSalary()
     {
        return _salary*12;
     }
     public int  RaiseSalary()
     {
        return _salary+= (_salary*10)/100;
     }
      public string Tostring()
      {
         return " \n id = " + GetId() + " \n FirsName = " + GetfirstName() + "\n LastName: " + GetLastName()+  "\n salary = " +  GetSalary() ;
      }
}