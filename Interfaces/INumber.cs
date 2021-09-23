using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionWebApp.Interfaces
{
    public interface INumber
    {
        int Number { get; set; }
    }

    public interface ITransientNumber : INumber
    {
    }

    public interface IScopedNumber : INumber
    {
    }

    public interface ISingletonNumber : INumber
    {
    }

    public interface ISingletonInstanceNumber : INumber
    {
    }

}
