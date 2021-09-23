using DependencyInjectionWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionWebApp.Services
{
    public class GetNumber : ITransientNumber, IScopedNumber, ISingletonNumber, ISingletonInstanceNumber
    {
        public int Number { get; set; }
        public GetNumber()
        {
            Random Rnd =new Random();
            Number = Rnd.Next(1, 15);
        }

        public GetNumber(int NewNumber)
        {
            Number = NewNumber;
        }
    }
}
