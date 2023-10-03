
using hm10_task3_cafe;

Cafe cafe = new Cafe();

cafe.AddNewEmployee(new Director("George", 36));
cafe.AddNewEmployee(new Cook("Richard", 45));
cafe.AddNewEmployee(new Cook("Jessica", 23));
cafe.AddNewEmployee(new Cook("Roger", 22));
cafe.AddNewEmployee(new Bartender("Alex", 25));
cafe.AddNewEmployee(new Bartender("Gloria", 21));
cafe.AddNewEmployee(new Waitor("Bridgette", 19));
cafe.AddNewEmployee(new Waitor("John", 26));
cafe.AddNewEmployee(new Waitor("Silvia", 31));
cafe.AddNewEmployee(new Waitor("Sam", 20));
cafe.AddNewEmployee(new Waitor("Miranda", 19));
cafe.AddNewEmployee(new Waitor("Samanta", 25));

foreach (var employee in cafe)
{
    employee.Info();
}