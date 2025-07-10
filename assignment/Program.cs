namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employees[] EmpArr = new Employees[3];

            EmpArr[0] = new Employees(
                id: 1,
                name: "hagar",
                gender: 'F',
                level: SecurityLevel.DBA,
                salary: 15000,
                hiredate: new HireDate(10, 3, 2021)
            );

            EmpArr[1] = new Employees(
                id: 2,
                name: "Ali",
                gender: 'M',
                level: SecurityLevel.Guest,
                salary: 5000,
                hiredate: new HireDate(1, 1, 2022)
            );

            EmpArr[2] = new Employees(
                id: 3,
                name: "saif",
                gender: 'M',
                level: SecurityLevel.SecurityOfficer,
                salary: 20000,
                hiredate: new HireDate(15, 7, 2020)
            );

            foreach (Employees emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
