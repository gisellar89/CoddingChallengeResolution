using CodingChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    #region Cuadrado
    public class Cuadrado : FormaB
    {
        
        public Cuadrado() { }
        
        public override string TraducirForma()
        {
            return (Strings.cuadrado);
        }

        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 4;
        }

        public override string ObtenerLinea()
        {
            return string.Format("1 {0} | {1} {2:#.##} | {3} {4:#.##} <br/>", TraducirForma(), Strings.area, CalcularArea(), Strings.perimetro, CalcularPerimetro());
        }

        public override int GetListCount()
        {
            return 1;
        }

        public override void Add(FormaB forma)
        {
            throw new System.NotImplementedException("No aplicable");
        }

        public override void Remove(FormaB forma)
        {
            throw new System.NotImplementedException("No aplicable");
        }
    }
    #endregion

    #region Triangulo
    public class TrianguloEquilatero : FormaB
    {
        public TrianguloEquilatero() { }
        
        public override string TraducirForma()
        {
            return Strings.triangulo;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 3;
        }

        public override string ObtenerLinea()
        {
            return string.Format("1 {0} | {1} {2:#.##} | {3} {4:#.##} <br/>", TraducirForma(), Strings.area, CalcularArea(), Strings.perimetro, CalcularPerimetro());
        }

        public override int GetListCount()
        {
            return 1;
        }

        public override void Add(FormaB forma)
        {
            throw new NotImplementedException("No aplicable");
        }

        public override void Remove(FormaB forma)
        {
            throw new NotImplementedException("No aplicable");
        }
    }
    #endregion

    #region Circulo
    public class Circulo : FormaB
    {

        public Circulo() { }
                
        public override string TraducirForma()
        {
            return (Strings.circulo);
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (Lado / 2) * (Lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Lado;
        }

        public override string ObtenerLinea()
        {
            return string.Format("1 {0} | {1} {2:#.##} | {3} {4:#.##} <br/>", TraducirForma(), Strings.area, CalcularArea(), Strings.perimetro, CalcularPerimetro());
        }

        public override int GetListCount()
        {
            return 1;
        }

        public override void Add(FormaB forma)
        {
            throw new NotImplementedException("No aplicable");
        }

        public override void Remove(FormaB forma)
        {
            throw new NotImplementedException("No aplicable");
        }
    }
    #endregion

    #region Trapecio
    public class Trapecio : FormaB
    {
        #region Properties
        public decimal Base1 { get; set; }
        public decimal Base2 { get; set; }
        public decimal Base3 { get; set; }
        public decimal Base4 { get; set; }
        public decimal Altura { get; set; }
        #endregion


        public Trapecio() { }

        public override string TraducirForma()
        {
            return (Strings.trapecio);
        }

        public override decimal CalcularArea()
        {
            return ((Base1 + Base2) / 2) * Altura;
        }

        public override decimal CalcularPerimetro()
        {
            return (Base1 + Base2 + Base3 + Base4);
        }

        public override string ObtenerLinea()
        {
            return string.Format("1 {0} | {1} {2:#.##} | {3} {4:#.##} <br/>", TraducirForma(), Strings.area, CalcularArea(), Strings.perimetro, CalcularPerimetro());
        }

        public override int GetListCount()
        {
            return 1;
        }

        public override void Add(FormaB forma)
        {
            throw new System.NotImplementedException("No aplicable");
        }

        public override void Remove(FormaB forma)
        {
            throw new System.NotImplementedException("No aplicable");
        }
    }
    #endregion

    #region Rectangulo
    public class Rectangulo : FormaB
    {
        #region Properties
        public decimal Base { get; set; }
        public decimal Altura { get; set; }
        #endregion


        public Rectangulo() { }

        public override string TraducirForma()
        {
            return (Strings.rectangulo);
        }

        public override decimal CalcularArea()
        {
            return ( (Base * Altura )/ 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (Base + Altura);
        }

        public override string ObtenerLinea()
        {
            return string.Format("1 {0} | {1} {2:#.##} | {3} {4:#.##} <br/>", TraducirForma(), Strings.area, CalcularArea(), Strings.perimetro, CalcularPerimetro());
        }

        public override int GetListCount()
        {
            return 1;
        }

        public override void Add(FormaB forma)
        {
            throw new System.NotImplementedException("No aplicable");
        }

        public override void Remove(FormaB forma)
        {
            throw new System.NotImplementedException("No aplicable");
        }
    }
    #endregion
}
