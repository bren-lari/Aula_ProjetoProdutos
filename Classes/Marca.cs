using System;
using System.Collections.Generic;

namespace Projeto_DeProdutos.Classes
{
    public class Marca
    {


        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        List<Marca> Marcas {get; set; }
 

        public Marca CadastrarMarca(){

              Marca marca = new Marca();

              Console.Write("Digite o código da marca: ");
              marca.Codigo = int.Parse(Console.ReadLine());

              Console.Write("\r\nDigite o nome da marca: ");
              marca.NomeMarca = Console.ReadLine();

              marca.DataCadastro = DateTime.UtcNow;

              Marcas.Add(marca);

              return marca;
        }

        public void Listar(){
            Console.WriteLine("Marcas cadastradas: ");
            foreach (var marcas in Marcas)
            {
                Console.WriteLine($"Código -> {marcas.Codigo}");
                Console.WriteLine($"\r\nMarca -> {marcas.Marcas}");
                Console.WriteLine($"\r\nData do cadastro da marca -> {marcas.DataCadastro}");


            }

        }

        public void Deletar(int _codigo){
            Marca marcaDelete = Marcas.Find(x => x.Codigo == Codigo);
            Marcas.Remove(marcaDelete);
 
    }
    }
}