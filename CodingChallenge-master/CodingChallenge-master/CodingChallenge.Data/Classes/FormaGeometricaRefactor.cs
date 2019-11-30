using CodingChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometricaRefactor
    {
        public static string Idioma {get; set;}

        public FormaGeometricaRefactor()
        {
        }

        public static string Imprimir(IEnumerable<FormaB> formas)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Idioma);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Idioma);
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(Strings.listaVaciaFormas); 
            }
            else
            {
                // HEADER
                sb.Append(Strings.reporteFormas);
                int cantidad = 0;
                decimal sumaAreas = 0m;
                decimal sumaPerimetros = 0m;

                foreach (var forma in formas)
                {
                    sb.Append(forma.ObtenerLinea());
                    cantidad += forma.GetListCount();
                    sumaAreas += forma.CalcularArea();
                    sumaPerimetros += forma.CalcularPerimetro();
                }

                // FOOTER
                sb.Append(Strings.total);
                sb.Append(cantidad + " " + Strings.forma + " ");
                sb.Append(Strings.perimetro + " " + sumaPerimetros.ToString("#.##") + " ");
                sb.Append(Strings.area + " " + sumaAreas.ToString("#.##"));
            }
            return sb.ToString();
        }

    }
}
