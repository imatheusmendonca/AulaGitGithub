using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGitGithub
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("VAMOS VERIFICAR SE VOCÊ ESTA APTO PARA TIRAR CNH");
            Console.WriteLine("Primeiro, digite seu nome: ");
            Console.ReadLine();
            Console.WriteLine("Ok, agora digite sua idade: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 18)
            {
                Console.WriteLine("Legal, você está apto para tirar a CNH");
            }
            else
            
                Console.WriteLine("Poxa, você não está apto!");
            
        }
    }
}

            

        
    

