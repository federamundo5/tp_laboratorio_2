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
        public string operar(Numero Numero1, Numero Numero2, String operador)
        {

            double Resultado = 0;

            switch (operador)
            {
                case "+":
                    Resultado = Numero1.getNumero() + Numero2.getNumero();
                    break;
                case "-":
                    Resultado = Numero1.getNumero() - Numero2.getNumero();
                    break;
                case "/":
   
                 if(Numero2.getNumero() == 0)
                    {
                        return "No se puede dividir por 0";
                    }
                    else
                    {
                        Resultado = Numero1.getNumero() / Numero2.getNumero();
                    }
                    break;
       
                case "*":
                    Resultado = Numero1.getNumero() * Numero2.getNumero();
                    break;
            }
         
            return Convert.ToString(Resultado);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public bool validarOperador(String operador)
        {

   

            if (operador == "+" || operador == "*" || operador == "-" || operador == "/")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
