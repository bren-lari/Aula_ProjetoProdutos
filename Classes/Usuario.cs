using System;

namespace Projeto_DeProdutos.Classes
{
    public class Usuario
    {
        // cadastrar usuário automaticamente
        public Usuario(){
           
        }

        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;
        }


        int Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

       DateTime DataCadastro { get; set; }


       public void Cadastrar(){

           Usuario usuario = new Usuario();

             Nome = "Brenda Larissa";
             Email = "brenlarissa@gmail";
             Senha = "123456";

        usuario.DataCadastro = DateTime.UtcNow;
       }


       public void Deletar(){
       }



    }
}