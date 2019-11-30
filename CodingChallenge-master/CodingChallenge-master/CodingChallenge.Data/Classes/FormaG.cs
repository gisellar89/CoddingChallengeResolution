using CodingChallenge.Data.Idiomas;
using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    #region Forma Genérica
    public abstract class FormaB: IFormaB
    {
        public decimal Lado { get; set; }

        public virtual string TraducirForma()
        {
            throw new NotImplementedException();
        }

        public virtual decimal CalcularArea()
        {
            throw new NotImplementedException();
        }

        public virtual decimal CalcularPerimetro()
        {
            throw new NotImplementedException();
        }

        public virtual string ObtenerLinea()
        {
            throw new NotImplementedException();
        }

        public virtual int GetListCount()
        {
            throw new NotImplementedException();
        }

        public abstract void Add(FormaB forma);
        public abstract void Remove(FormaB forma);
    }
    #endregion

    #region Lista Formas
    public class ListadoFormas<T> : FormaB where T : FormaB
    {
        private List<T> ListFormas { get; set; }

        public ListadoFormas()
        {
            ListFormas = new List<T>();
        }

        public ListadoFormas(List<T> listado)
        {
            this.ListFormas = new List<T>();
            this.ListFormas = listado;
        }

        public override string TraducirForma()
        {
            if (ListFormas.Any() && ListFormas.Count > 0)
                return ListFormas.FirstOrDefault().TraducirForma();

            return string.Empty;
        }

        public override decimal CalcularArea()
        {
            decimal area = 0;

            foreach (T forma in ListFormas)
                area += forma.CalcularArea();

            return area;
        }

        public override decimal CalcularPerimetro()
        {
            decimal perimetro = 0;

            foreach (T forma in ListFormas)
                perimetro += forma.CalcularPerimetro();

            return perimetro;
        }

        public override string ObtenerLinea()
        {
            if (ListFormas.Any())
            {
                return string.Format("{0} {1} | {2} {3:#.##} | {4} {5:#.##} <br/>", ListFormas.Count, TraducirForma(), Strings.area, CalcularArea(), Strings.perimetro, CalcularPerimetro());                
            }

            return string.Empty;
        }

        public override int GetListCount()
        {
            return ListFormas.Count;
        }

        public override void Add(FormaB forma)
        {
            this.ListFormas.Add((T)forma);
        }

        public override void Remove(FormaB forma)
        {
            this.ListFormas.Remove((T)forma);
        }
    }
    #endregion
}
