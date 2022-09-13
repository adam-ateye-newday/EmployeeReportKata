namespace EmployeeReportKata
{
    public class UnitTest1
    {
        [Fact]
        public void GetAdultEmployees()
        {
            //Arrange
            Emp employee = new Emp();
            //Act
            var possibleSundayWorkers = employee.CheckAge();
            //Assert
            Assert.Equal(2, possibleSundayWorkers);
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Employee() { }

    }
    public class Emp
    {
        public List<Employee> employees = new List<Employee>()
    {
        new Employee ("max", 17),
        new Employee ("sepp", 18),
        new Employee ("nina", 15),
        new Employee ("mike", 51)

    };

        public int CheckAge() => employees.Where(Employee => Employee.Age >= 18).Count();
    }

}