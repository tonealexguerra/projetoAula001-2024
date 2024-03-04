using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto001_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string nome;
            string idade;

            int anoNascimento;
            
            
            Console.WriteLine("Iniciamos o Projeto: Aprendendo C#");
            Console.WriteLine("Começaremos recebendo uma informação digitada pelo usuário! \nDigite seu nome:");

            nome = Console.ReadLine();
            Console.WriteLine($"Aqui vamos interpolar o nome digitado, veja: {nome}");

            idade = Console.ReadLine();
            Console.WriteLine($"Vamos exibir a idade digitada: {idade}");

            anoNascimento = 2024 - int.Parse(idade);
            Console.WriteLine($"Agora sim temos o ano de nascimento: {anoNascimento}");
            */


            /*
            Pessoa x = new Pessoa();
            Console.WriteLine("DIGITE O NOME DA PESSOA");
            x.setNome(Console.ReadLine());

            Console.WriteLine("DIGITE a IDADE DA PESSOA");
            x.setIdade(int.Parse(Console.ReadLine()));

            var dados = x.getDados();

            Console.WriteLine($"Aqui está o nome do usuário: "+ dados[0]);
            Console.WriteLine($"Aqui está a idade do usuário: {x.getIdade()}");
            Console.WriteLine($"Aqui está o ano de nascimento: {x.getAnoNascimento()}");
            Console.WriteLine(dados.Count);
            */

            int x = 10;

            int y = 10;

            int total = x + y;

            Console.WriteLine("mensagem = " + total);
            Console.WriteLine($"mensagem = {total}");

            int[] v = new int[3];
            v[0] = 50;
            v[1] = 51;
            v[2] = 52;

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }

            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add("Tone");
            al.Add(1.70);

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(al[i]);
            }
            var total2 = int.Parse(al[0].ToString()) + 100;
            Console.WriteLine(total2 + "%");

            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


            List<Pessoa> agenda = new List<Pessoa>();


            

            Pessoa b = new Pessoa();
            b.setNome("Manuela");
            b.setIdade(35);

            Boolean resposta = true;

            while (resposta)
            {
                try
                {
                    Pessoa a = new Pessoa();
                    a.setNome(Console.ReadLine());
                    a.setIdade(int.Parse(Console.ReadLine()));
                    agenda.Add(a);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro de conversão: {e.Message}");
                }
                finally
                {
                    Console.WriteLine("Deseja adicionar um novo contato? S/N");
                    string key = Console.ReadLine();
                    if( key != "s") {
                        resposta = false;
                    }
                }
                
            }

            
            
            agenda.Add(b);

            foreach(Pessoa pessoa in agenda)
            {
                Console.WriteLine(pessoa.getNome());
                Console.WriteLine(pessoa.getIdade());
                Console.WriteLine(pessoa.getAnoNascimento());
                Console.WriteLine(" ");
            }


        }
    }
}
