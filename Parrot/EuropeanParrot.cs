using System;
using System.Collections.Generic;

namespace Parrot
{
    public class EuropeanParrot : Parrot
    {
        public EuropeanParrot() : base(ParrotTypeEnum.EUROPEAN, 0, 0, true)
        {

        }
         
        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }

        public override string GetCry()
        {
            return "Sqoork!";
        }

    }
}