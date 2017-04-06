using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Numero
    {
        double numero;

        #region constructores
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(String numero)
        {
            this.numero = Double.Parse(numero);
        }

        #endregion

        /// <summary>
        /// Setter
        /// </summary>
        /// <param name="numero">Numero a setear</param>
        public void setNumero(String numero)
        {
            this.numero = validarNumero(numero);
        }

        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Retorna numero</returns>
        public double getNumero()
        {
            return this.numero;
        }

        /// <summary>
        /// Valida Numero tratandolo de pasear
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns> numero parseado o 0</returns>
        private double validarNumero(string numeroString)
        {
            double aux;

            if (!(double.TryParse(numeroString, out aux)))
            aux = 0;
            
            return aux;
        }
    }
}
