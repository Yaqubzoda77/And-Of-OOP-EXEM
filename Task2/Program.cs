Employee ForWork = new Employee(123 ,"Yaqubzoda ",  "Muhammad", 2500 );
System.Console.WriteLine(ForWork.GetId());
System.Console.WriteLine(ForWork.GetFirstName());
System.Console.WriteLine(ForWork.GetLastName());
System.Console.WriteLine(ForWork.GetName());
System.Console.WriteLine(ForWork.GetSalary());
  ForWork.SetSalary(3000);
  System.Console.Write("Your AnnualSalary = ");
  System.Console.WriteLine(ForWork.GetAnnualSalary());
  System.Console.WriteLine(ForWork.RaiseSalary(10));
  System.Console.WriteLine(ForWork.ToString());
