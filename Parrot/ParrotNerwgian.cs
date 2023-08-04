using System;

namespace Parrot
{
    public class ParrotNerwgian : Parrot
    {
        
        public ParrotNerwgian(double v, bool isNailed) : base(ParrotTypeEnum.NORWEGIAN_BLUE, 0, v, isNailed)
        {
             
        }
        public ParrotNerwgian(double v) : base(ParrotTypeEnum.NORWEGIAN_BLUE, 0, v, true)
        {
             
        }
        public override double GetSpeed()
        {
            return GetisNailed() ? 0 : GetBaseSpeed(getVoltage());
            // return  GetBaseSpeed(getVoltage());
        }
        public override string GetCry()
        {
            
            return   getVoltage() > 0 ? "Bzzzzzz" : SILENT;
            
        }
        
    }
}