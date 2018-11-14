using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYears = 2080;
        public decimal GetnnualSallary(decimal hourlywage)=>(hourlywage*HoursInYears);
        
        public decimal horlywage(int anualsalary )=> anualsalary / HoursInYears;

    }
}
