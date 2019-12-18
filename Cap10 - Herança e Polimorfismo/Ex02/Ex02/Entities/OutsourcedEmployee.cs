﻿namespace Ex02.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; protected set; }

        public OutsourcedEmployee
            (string name, int hours, double valuePerHour, double additionalCharge) 
            :base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (1.10 * AdditionalCharge);
        }
    }
}
