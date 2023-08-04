using System;
using System.Collections.Generic;

namespace Parrot
{
    public  class Parrot
    {
        private const double GETBASESPEED = 12.0;
        private const double GETLOADFACTOR = 9.0;
        public const string SILENT = "...";
        private readonly bool _isNailed;
        private readonly int _numberOfCoconuts;
        private readonly ParrotTypeEnum _type;
        private readonly double _voltage;

        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _type = type;
            _numberOfCoconuts = numberOfCoconuts;
            _voltage = voltage;
            _isNailed = isNailed;
        }
        
        public virtual double GetSpeed()
        {
            return GetBaseSpeed();
        }

        public virtual double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

        public virtual double GetLoadFactor()
        {
            return GETLOADFACTOR;
        }

        public virtual double GetBaseSpeed()
        {
            return GETBASESPEED;
        }
        

        public virtual string GetCry()
        {
            
            return SILENT;
        }

        public static Parrot create(ParrotTypeEnum _type, int _numberOfCoconuts, double _voltage, bool _isNailed)
        {
            return new Parrot(_type, _numberOfCoconuts,_voltage,_isNailed);
        }
        public virtual int getNumberOfCoconuts(){
            return _numberOfCoconuts;
        }
        public virtual double getVoltage()
        {
           return _voltage;
        }
        public bool GetisNailed()
        {
            return _isNailed;
        }
    }
}