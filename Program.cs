using System;

namespace Employee_Wages_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("----------------------\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Employee_Wages_Computation.UC1_EmpCheck uc1 = new  UC1_EmpChecke();
                        uc1.CheckDailySalary();
                        break;
                    case 2:
                        Employee_Wages_Computation.UC2_DailyWage uc2 = new UC2_DailyWage();
                        uc2.EmpDailyWage();
                        break;
                    case 3:
                        Employee_Wages_Computation.UC3_PartTimeEmpAndWage uc3 = new UC3_PartTimeEmpAndWage();
                        uc3.CheckPartTimeEmpWage();
                        break;
                    case 4:
                        Employee_Wages_Computation.UC4_PartTimeEmpWage_usingSwitch  uc4 = new UC4_PartTimeEmpWage_usingSwitch ();
                        uc4.CheckEmpWageUsingSwitch();
                        break;
                    case 5:
                       Employee_Wages_Computation.UC5_CalculateEmpSalaryForMonth uc5 = new UC5_CalculateEmpSalaryForMonth();
                        uc5.CheckFor20DaysInMonth();
                        break;
                    case 6:
                        Employee_Wages_Computation.UC6_SalaryForTotalWorkingHrs100_OrMonthsOf20 uc6 = new UC6_SalaryForTotalWorkingHrs100_OrMonthsOf20();
                        uc6.CheckUC6_SalaryForTotalWorkingHrs100_OrMonthsOf20();
                        break;
                    case 7:
                        Employee_Wages_Computation.UC7_RefactorTheCodeUsingClass uc7 = new UC7_RefactorTheCodeUsingClass
                        UC7_RefactorTheCodeUsingClass.ComputeEmpWage();
                        break;
                    case 8:
                        ComputeEmpWageClass uc8 = new ComputeEmpWageClass();
                        uc8.computeEmpWageInCompanies("Dmart", 20, 2, 10);

                        computeEmpWageClass.computeEmpWageInCompsnies("Reliance", 10, 4, 20);
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
                 
          
        }
    }
}
