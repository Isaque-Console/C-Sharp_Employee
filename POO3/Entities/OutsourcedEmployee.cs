using System;
using System.Collections.Generic;
using System.Text;

namespace POO3.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalcharge) : base(name, hours, valuePerHour )
        {
            AdditionalCharge = additionalcharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + (1.1 * AdditionalCharge);
        }



    }
}
