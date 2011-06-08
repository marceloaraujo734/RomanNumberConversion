using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumberConversionFramework
{
    public class ConversorNumerosRomanos
    {
        public int ConverterParaInteiro(char pNumeroRomano)
        {
            if (pNumeroRomano == 'I') return 1;

            if (pNumeroRomano == 'V') return 5;

            if (pNumeroRomano == 'X') return 10;

            throw new ArgumentOutOfRangeException("pNumeroRomano");
        }

        public int ConverterParaInteiro(string pNumeroRomano)
        {
            var total = 0;

            for (int i = 0; i < pNumeroRomano.Length; i++)
            {
                var valorCaracterAtual = this.ConverterParaInteiro(pNumeroRomano[i]);
                var indiceAnterior = i - 1;
                var valorCatacterAnterior = valorCaracterAtual;

                if (indiceAnterior >= 0)
                    valorCatacterAnterior = this.ConverterParaInteiro(pNumeroRomano[indiceAnterior]);

                if (valorCaracterAtual > valorCatacterAnterior)
                {
                    total = valorCaracterAtual - total;
                }
                else
                {
                    total += valorCaracterAtual;
                }

            }

            return total;
        }
    }
}
