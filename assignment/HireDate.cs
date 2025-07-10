using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class HireDate
{
    private int day;
    private int year;
    private int month;

    public HireDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public int Day
    {
        get { return day; }
        set
        {
            if (value > 0 && value <= 31)
                day = value;
            else
                throw new ArgumentException("Invalid day");
        }
    }

    public int Month
    {
        get { return month; }
        set
        {
            if (month > 0 && month <= 12)
                month = value;
            else
            {
                throw new ArgumentException("invalid month");
            }
        }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public override string ToString()
    {
        return $"{Day}/ {month} / {year}";
    }

    public DateTime ToDateTime()
    {
        return new DateTime(Year, Month, Day);
    }
}
