using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public enum SecurityLevel
{
    Guest,
    Developer,
    secretary,
    DBA,
    SecurityOfficer
}

public class Employees
{
    private int id;
    private string name;
    private SecurityLevel security_level;
    private double salary;
    private HireDate hiredate;
    private char gender;

    public Employees(int id, string name, SecurityLevel level, double salary, HireDate hiredate
        , char gender)
    {
        this.id = id;
        this.name = name;
        this.security_level = level;
        this.salary = salary;
        this.gender = gender;
        this.hiredate = hiredate;
    }


    public HireDate HireDate
    {
        get { return hiredate; }
        set { hiredate = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public char Gender
    {
        get { return this.gender; }
        set
        {
            if (value == 'M' || value == 'F')
                this.gender = value;
            else
                throw new ArgumentException("gender must be M or F");
        }
    }

    public override string ToString()
    {
        return
        $"ID : {id}\n" +
        $"Name : {name}\n" +
        $"Salary : {string.Format("{0:C}", salary)}\n" +
        $"Gender : {gender}\n" +
        $"Security Level:{security_level} " +
        $"Hire Date: {hiredate}"; ;
    }
}
