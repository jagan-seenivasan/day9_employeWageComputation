using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages_Computation
{
    interface UC8_FromMultipleCompany
    {
        public int computeEmpWageInCompsnies(string company, int empRatePerHour, int numOfWorkingDays, int MaxHoursPerMonth);
    }
}
