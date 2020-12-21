using System;

namespace Projeto_DeProdutos.Classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login(){
            Usuario user = new Usuario();
            Logar(user);

            if(Logado){
                GerarMenu();

            }

        }

        public void GerarMenu(){

            Produto prod = new Produto();
            Marca marc = new Marca();


            string opcao = "n";

            do{
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1º -> Cadastrar produtos ");
                Console.WriteLine("2º -> Listar produtos ");
                Console.WriteLine("3º -> Deletar produtos ");
                Console.WriteLine("4º -> Cadastrar marca");
                Console.WriteLine("5º -> Listar marca");
                Console.WriteLine("6° -> Deletar marca");
                Console.WriteLine("0 Sair ");
                opcao = Console.ReadLine();

                switch (opcao){
                    case "1":
                    prod.Cadastrar();
                    break;

                    case "2":
                    prod.Listar();
                    break;

                    case "3":
                    Console.WriteLine("Digite um código para excluir: ");
                    int cod = int.Parse(Console.ReadLine());
                    prod.Deletar(cod);
                    break;

                    case "4":
                    marc.CadastrarMarca();
                    prod.Cadastrar();
                    break;

                    case "5":
                     marc.Listar();
                    break;

                    case "6":
                    Console.WriteLine("Digite um código para excluir: ");
                    int codMarca = int.Parse(Console.ReadLine());
                    marc.Deletar(codMarca);
                    break;
                }

            }while(opcao != "0");
        }


        
        public void Logar(Usuario usuario){
            Console.Write("Digite seu Email: ");
            string emailLogin = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha){
                Logado = true;
                Console.WriteLine("Login efetuado!!!");

            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Email ou senha inválidos!");
            }
            Console.ResetColor();

        }

        public void Deslogar(){
            

        }
        
    }
}