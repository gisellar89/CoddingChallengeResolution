using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Interfaces
{
    public interface IFormaB
    {
        decimal Lado { get; set; }
        string TraducirForma();
        decimal CalcularArea();
        decimal CalcularPerimetro();        
    }
}
