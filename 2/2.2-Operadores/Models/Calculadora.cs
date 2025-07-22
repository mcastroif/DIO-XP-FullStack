using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Calculadora
    {

        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }


        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }


        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }


        public void Dividir(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }
            else
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }
        }


        public void Potenciação(int x, int y)
        {

            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");

        }

        public void Seno(double angulo)
        {
            double rad = angulo * (Math.PI / 180); // Convertendo graus para radianos
            double seno = Math.Sin(rad);
            Console.WriteLine($"Seno de {angulo}  = {Math.Round(seno),4}"); // Arredondando para 4 casas decimais
            // Math.Round é usado para arredondar o resultado
        }

        public void Coseno(double angulo)
        {
            double rad = angulo * (Math.PI / 180); // Convertendo graus para radianos
            double coseno = Math.Cos(rad);
            Console.WriteLine($"Coseno de {angulo}  = {Math.Round(coseno),4}"); // Arredondando para 4 casas decimais
            // Math.Round é usado para arredondar o resultado
        }

        public void Tangente(double angulo)
        {
            double rad = angulo * (Math.PI / 180); // Convertendo graus para radianos
            double tangente = Math.Tan(rad);
            Console.WriteLine($"Tangente de {angulo}  = {Math.Round(tangente),4}"); // Arredondando para 4 casas decimais
            // Math.Round é usado para arredondar o resultado
        }
        
    }
}