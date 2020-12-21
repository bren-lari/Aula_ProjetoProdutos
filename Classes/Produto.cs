using System;
using System.Collections.Generic;

namespace Projeto_DeProdutos.Classes
{
    public class Produto
    {
       public  int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; }

        public Marca Marca { get; set; }

        public Usuario CadastradoPor { get; set; }

        public List<Produto> ListaDeProduto { get; set; }


        public void Cadastrar(){
            Produto NovoProduto = new Produto();

            Console.Write("Digite o código do produto: ");
            NovoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            NovoProduto.NomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            NovoProduto.Preco = float.Parse(Console.ReadLine());

            NovoProduto.DataCadastro = DateTime.UtcNow;

            NovoProduto.Marca = Marca.CadastrarMarca();

            NovoProduto.CadastradoPor = new Usuario();

            ListaDeProduto.Add(NovoProduto);


        }

        public void Listar(){

            Console.ForegroundColor = ConsoleColor.Magenta;

            foreach (var item in ListaDeProduto)
            {
                Console.WriteLine($"Código -> {item.Codigo}");
                Console.WriteLine($"Produto -> {item.NomeProduto}");
                Console.WriteLine($"Preço -> {item.Preco}");
                Console.WriteLine($"Data do produto cadastrado -> {item.DataCadastro}");
                Console.WriteLine($"Marca -> {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por:  -> {item.CadastradoPor}");
                Console.WriteLine();
            }

            Console.ResetColor();

        }

        public void  Deletar(int Codigo){
            Produto prodDelete = ListaDeProduto.Find(p => p.Codigo == Codigo);
            ListaDeProduto.Remove(prodDelete);

        }
    }
}