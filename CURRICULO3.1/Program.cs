using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURRICULO3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String sobrenome;
            String data_nascimento;
            String endereço;
            String sexo;
            String escolaridade;
            String cursos_extra_curriculares;
            String experiencia_profissional;
            String email;
            String telefone;

            Console.WriteLine("nome");
            nome = Console.ReadLine();
            Console.WriteLine("sobrenome");
            sobrenome = Console.ReadLine();
            Console.WriteLine(nome + " " + sobrenome);
            Console.WriteLine("email");
            email = Console.ReadLine();
            Console.WriteLine("telefone");
            telefone = Console.ReadLine();
            Console.WriteLine("data de nascimento");
            data_nascimento = Console.ReadLine();
            Console.WriteLine("endereço");
            endereço = Console.ReadLine();
            Console.WriteLine("sexo");
            sexo = Console.ReadLine();
            Console.WriteLine("escolaridade");
            escolaridade = Console.ReadLine();
            Console.WriteLine("cursos extra-curriculares");
            cursos_extra_curriculares = Console.ReadLine();
            Console.WriteLine("experiencia profissional");
            experiencia_profissional = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
