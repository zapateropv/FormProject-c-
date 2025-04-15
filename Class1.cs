using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinActZapatero
{

    internal class Class1
    {

        private string name = " ";
        private double daysWorked, ratePerDay, pagIbig, SSS, 
        PhilHealth, TotalDeduction, GrossPay, NetPay;


        public void setName(string name)
        {
            this.name = name;
        }

        public void setDaysWorked(double daysWorked)
        {
            this.daysWorked = daysWorked;
        }

        public void setRatePerDay(double ratePerDay)
        {
            this.ratePerDay = ratePerDay;
        }


        public string getGreeting()
        {
            return "Hello, " + this.name;
        }

        public double getGrossPay()
        {

            GrossPay = this.ratePerDay * this.daysWorked;
            return GrossPay;
        }


        public void setPagIbig(double pagIbig)
        {
            this.pagIbig = pagIbig;
        }


        public void setSSS(double sss)
        {
            this.SSS = sss;
        }

        public void setPhilHealth(double PhilHealth)
        {
            this.PhilHealth = PhilHealth;
        }

        public double getTotalDeduction()
        {
            TotalDeduction = this.pagIbig + this.SSS + this.PhilHealth;

            return TotalDeduction;
        }


        public double getNetPay()
        {
            NetPay = GrossPay - TotalDeduction;
            return NetPay;
        }

       

    }
}
