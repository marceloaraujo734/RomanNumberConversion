using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumberConversionFramework;

namespace RomanNumberConversion.Testes
{
    [TestClass]
    public class ConversaoNumerosRomanosTestes
    {
        // Dica 1: Sempre inicie com uma lista de testes;
        // Dica 2: Sempre inicie pela implementação mais simples;

        /*
         * Lista de testes:
         * 
         *  - Deve converter de I para 1; (OK)
         *  - Deve converter de II para 2; (OK)
         *  - Deve converter de III para 3; (OK)
         *  - Deve converter de IV para 4; (OK)
         *  - Deve converter de V para 5; (OK)
         *  - Deve converter de VI para 6; (OK)
         *  - Deve converter de VII para 7; (OK)
         *  - Deve converter de VIII para 8; (OK)
         *  - Deve converter de IX para 9; (OK)
         *  - Deve converter de X para 10; (OK)
         *  - Deve dar erro com caracteres desconhecidos; (OK)
         * 
         */

        // Dica 3: Comece a construção do seu código pela construção do teste;
        // Dica 4: Comece a construção do seu teste pela definição de sua assertiva;
        // Mantra: Vermelho -> Verde -> Refatorar
        // Dica 5: Simule até construir realmente;
        // Dica 6: Busque o verde o mais rápido possível;

        [TestMethod]
        public void Deve_converter_I_para_1()
        {
            var conversor = new ConversorNumerosRomanos();

            Assert.AreEqual(1, conversor.ConverterParaInteiro('I'));
        }

        // Dica 7: Construa somente o necessário para o seu teste passar;

        [TestMethod]
        public void Deve_converter_V_para_5()
        {
            var conversor = new ConversorNumerosRomanos();

            Assert.AreEqual(5, conversor.ConverterParaInteiro('V'));
        }

        [TestMethod]
        public void Deve_converter_X_para_10()
        {
            var conversor = new ConversorNumerosRomanos();

            Assert.AreEqual(10, conversor.ConverterParaInteiro('X'));
        }

        // Dica 8: Passos de bebê;

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Deve_disparar_excecao_com_caracteres_desconhecidos()
        {
            var conversor = new ConversorNumerosRomanos();

            conversor.ConverterParaInteiro('Z');
        }

        [TestMethod]
        public void Deve_converter_II_para_2()
        {
            var conversor = new ConversorNumerosRomanos();

            Assert.AreEqual(2, conversor.ConverterParaInteiro("II"));
        }

        [TestMethod]
        public void Deve_converter_III_para_3()
        {
            var conversor = new ConversorNumerosRomanos();

            Assert.AreEqual(3, conversor.ConverterParaInteiro("III"));
        }

        // Dica 9: Construa testes semelhantes com dados distintos (Triangulação);

        [TestMethod]
        public void Deve_converter_VI_para_6()
        {
            var conversor = new ConversorNumerosRomanos();

            Assert.AreEqual(6, conversor.ConverterParaInteiro("VI"));
        }

        [TestMethod]
        public void Deve_converter_VII_para_7()
        {
            var conversor = new ConversorNumerosRomanos();

            Assert.AreEqual(7, conversor.ConverterParaInteiro("VII"));
        }

        [TestMethod]
        public void Deve_converter_VIII_para_8()
        {
            var conversor = new ConversorNumerosRomanos();

            Assert.AreEqual(8, conversor.ConverterParaInteiro("VIII"));
        }

        [TestMethod]
        public void Deve_converter_IV_para_4()
        {
            var conversor = new ConversorNumerosRomanos();

            Assert.AreEqual(4, conversor.ConverterParaInteiro("IV"));
        }

        [TestMethod]
        public void Deve_converter_IX_para_9()
        {
            var conversor = new ConversorNumerosRomanos();

            Assert.AreEqual(9, conversor.ConverterParaInteiro("IX"));
        }
    }
}
