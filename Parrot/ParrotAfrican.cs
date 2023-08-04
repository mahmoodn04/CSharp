using System;
using System.Collections.Generic;

namespace Parrot
{
    public class ParrotAfrican : Parrot
    {
        

        public ParrotAfrican() : base(ParrotTypeEnum.AFRICAN, 0, 0, false)
        {
            
        }

        
        public ParrotAfrican(int v) : base(ParrotTypeEnum.AFRICAN, v, 0, false)
        {
            
        }

        public override double GetSpeed()
        {
           return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * getNumberOfCoconuts());
        }
        public override string GetCry()
        {
            return "Sqaark!";
        }
    }
}