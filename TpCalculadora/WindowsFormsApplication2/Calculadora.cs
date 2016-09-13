using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Calculadora
    {
        /// <summary>
        /// Realiza una operacion según el operador
        /// </summary>
        /// <param name="Numero1">Primer numero</param>
        /// <param name="Numero2"> Segundo Numero</param>
        /// <param name="operador">Operador</param>
        /// <returns>Retorna un double con el resultado</returns>
        public double operar(Numero Numero1, Numero Numero2, String operador)
        {

            Double Resultado = 0;

            switch (operador)
            {
                case "+":
                    Resultado = Numero1.getNumero() + Numero2.getNumero();
                    break;
                case "-":
                    Resultado = Numero1.getNumero() - Numero2.getNumero();
                    break;
                case "/":
                  Resultado = Numero1.getNumero() / Numero2.getNumero();
                  break;
                case "*":
                    Resultado = Numero1.getNumero() * Numero2.getNumero();
                    break;
            }
      
            return Resultado;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public String validarOperador(String operador)
        {

            string aux = "+";

            if (operador == "+" || operador == "*" || operador == "-" || operador == "/")
            {
                aux = operador;
            }
            else
            {
                //Error
            }

            return aux;
        }
    }
}
