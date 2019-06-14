using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoOnline.DominioTest.Curso
{
    public class CursoTest
    {

        [Fact]
        public void CriarCurso()
        {
            var curso = new Curso(nome, cargaHoraria, publicoAlvo, valor);

            Assert.Equal(nome, curso.Nome);
            Assert.Equal(cargaHoraria, curso.CargaHoraria);
            Assert.Equal(publicoAlgo, curso.PublicoAlvo);
            Assert.Equal(valor, curso.Valor);
        }
    }

    public class Curso {

        public Curso() {
            throw new NotImplementedException();
        }

    }
}
