using MyModel;
using System;

namespace ForceCal
{
    public class Logic : ILogic
    
    {
        public double Multiply(MultiplyViewModel model)
        {
            var reply = model.Mass * model.Acceleration;
            return reply;
        }
    }
}
