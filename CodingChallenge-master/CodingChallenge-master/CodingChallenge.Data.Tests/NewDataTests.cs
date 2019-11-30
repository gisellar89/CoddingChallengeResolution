using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;
using CodingChallenge.Data.Idiomas;
using System.Threading;
using System.Globalization;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class NewDataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            FormaGeometricaRefactor.Idioma = "es-AR";
            IEnumerable<FormaB> formas = new List<ListadoFormas<Cuadrado>>();

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometricaRefactor.Imprimir(formas));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            FormaGeometricaRefactor.Idioma = "en-US";
            IEnumerable<FormaB> formas = new List<ListadoFormas<Cuadrado>>();

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometricaRefactor.Imprimir(formas));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnPortugues()
        {
            FormaGeometricaRefactor.Idioma = "pt-BR";
            IEnumerable<FormaB> formas = new List<ListadoFormas<Cuadrado>>();

            Assert.AreEqual("<h1>Lista vazia de Formulários!</h1>",
                FormaGeometricaRefactor.Imprimir(formas));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            FormaGeometricaRefactor.Idioma = "es-AR";
            IEnumerable<FormaB> formas = new List<Cuadrado> { new Cuadrado() { Lado = 5 } };

            var resumen = FormaGeometricaRefactor.Imprimir(formas);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrados | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 Formas Perímetro 20 Área 25", resumen);

        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            FormaGeometricaRefactor.Idioma = "en-US";
            var cuadrados = new ListadoFormas<FormaB>();
            cuadrados.Add(new Cuadrado() { Lado = 5 });
            cuadrados.Add(new Cuadrado() { Lado = 1 });
            cuadrados.Add(new Cuadrado() { Lado = 3 });

            var resumen = FormaGeometricaRefactor.Imprimir(new List<ListadoFormas<FormaB>> { cuadrados });

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            FormaGeometricaRefactor.Idioma = "en-US";
            IEnumerable<FormaB> formas = new List<Trapecio> { new Trapecio() { Base1 = 5, Base2 = 6, Base3 = 4, Base4 = 3, Altura = 8 } };

            var resumen = FormaGeometricaRefactor.Imprimir(formas);

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapeziums | Area 44 | Perimeter 18 <br/>TOTAL:<br/>1 shapes Perimeter 18 Area 44", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioRectangulo()
        {
            FormaGeometricaRefactor.Idioma = "en-US";
            IEnumerable<FormaB> formas = new List<FormaB>
            {
                new Trapecio() { Base1 = 5, Base2 = 6, Base3 = 4, Base4 = 3, Altura = 8 },
                new Rectangulo() { Base = 5, Altura = 8 }
            };

            var resumen = FormaGeometricaRefactor.Imprimir(formas);

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapeziums | Area 44 | Perimeter 18 <br/>1 Rectangle | Area 20 | Perimeter 13 <br/>TOTAL:<br/>2 shapes Perimeter 31 Area 64", resumen);//TODO: calcular ver como debe quedar
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            FormaGeometricaRefactor.Idioma = "en-US";
            var formasCuadrado = new ListadoFormas<FormaB>();
            formasCuadrado.Add(new Cuadrado() { Lado = 5 });
            formasCuadrado.Add(new Cuadrado() { Lado = 2 });

            var formasCirculo = new ListadoFormas<FormaB>();
            formasCirculo.Add(new Circulo() { Lado = 3 });
            formasCirculo.Add(new Circulo() { Lado = 2.75m });

            var formasTriangulo = new ListadoFormas<FormaB>();
            formasTriangulo.Add(new TrianguloEquilatero() { Lado = 4 });
            formasTriangulo.Add(new TrianguloEquilatero() { Lado = 9 });
            formasTriangulo.Add(new TrianguloEquilatero() { Lado = 4.2m });

            var TodasLasFormas = new List<ListadoFormas<FormaB>> { formasCuadrado, formasCirculo, formasTriangulo };
            var resumen = FormaGeometricaRefactor.Imprimir(TodasLasFormas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            FormaGeometricaRefactor.Idioma = "es-AR";
            string lalal =  Strings.reporteFormas;
            var formasCuadrado = new ListadoFormas<FormaB>();
            formasCuadrado.Add(new Cuadrado() { Lado = 5 });
            formasCuadrado.Add(new Cuadrado() { Lado = 2 });

            var formasCirculo = new ListadoFormas<FormaB>();
            formasCirculo.Add(new Circulo() { Lado = 3 });
            formasCirculo.Add(new Circulo() { Lado = 2.75m });

            var formasTriangulo = new ListadoFormas<FormaB>();
            formasTriangulo.Add(new TrianguloEquilatero() { Lado = 4 });
            formasTriangulo.Add(new TrianguloEquilatero() { Lado = 9 });
            formasTriangulo.Add(new TrianguloEquilatero() { Lado = 4.2m });

            var TodasLasFormas = new List<ListadoFormas<FormaB>> { formasCuadrado, formasCirculo, formasTriangulo };
            var resumen = FormaGeometricaRefactor.Imprimir(TodasLasFormas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 Formas Perímetro 97,66 Área 91,65",
                resumen);
        }
    
    }
}
