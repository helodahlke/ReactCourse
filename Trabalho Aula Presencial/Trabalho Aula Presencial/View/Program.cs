using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Aula_Presencial.Model;
using Trabalho_Aula_Presencial.DAO;
/* 
 * Heloisa Fagundes Dahlke 
 * Matricula: 1600533
 */

namespace Trabalho_Aula_Presencial.View
{
    class Program
    {
        static void Main(string[] args)
        {


            PedidoDAO pdDao = new PedidoDAO();

            Console.WriteLine("Usuários cadastrados com sucesso!\n\n");
            Console.WriteLine("Selecione uma opção: \n");
            Console.WriteLine("1 - Cadastrar \n");
            Console.WriteLine("2 - Listar Todos \n");
            Console.WriteLine("3 - Buscar por nome \n");
            Console.WriteLine("4 - Remover \n");
            Console.WriteLine("5 - Alterar \n");
            Console.WriteLine("0 - Sair ");
            String opcao = Console.ReadLine();

            if (opcao.Equals("0"))
            {
                System.Environment.Exit(1);

            }
            if (opcao.Equals("1"))
            {


                    Pedido pedido = new Pedido();

                    Console.WriteLine("Digite o nome do produto: \n");
                    pedido.Produto = Console.ReadLine();
                    Console.WriteLine("Digite a quantidade do produto: \n");
                    pedido.Quantidade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor do produto: \n");
                    pedido.Valor = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a data de cadastro: \n");
                    pedido.Data = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Digite o nome do fornecedor: \n");
                    pedido.Fornecedor = Console.ReadLine();

                    pdDao.Cadastrar(pedido);
                                
            }
            if (opcao.Equals("2"))
            {
                pdDao.Listar();
            }
            if (opcao.Equals("3"))
            {
                Pedido pedido = new Pedido();
                Console.WriteLine("Nome do produto que deseja buscar: ");
                pedido.Produto = Console.ReadLine();
                pdDao.Buscar(pedido);
            }
            if (opcao.Equals("4"))
            {
                Pedido pedido = new Pedido();
                Console.WriteLine("Nome do produto que deseja deletar: ");
                pedido.Produto = Console.ReadLine();
                pdDao.Remover(pedido);
            }
            if (opcao.Equals("5"))
            {
                Pedido pedido = new Pedido();
                Console.WriteLine("Nome do produto que deseja alterar: ");
                pedido.Produto = Console.ReadLine();
                pdDao.Buscar(pedido);
               

                Pedido novoPedido = new Pedido();
                Console.WriteLine("Digite o nome do produto: \n");
                novoPedido.Produto = Console.ReadLine();
                Console.WriteLine("Digite a quantidade do produto: \n");
                novoPedido.Quantidade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o valor do produto: \n");
                novoPedido.Valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a data de cadastro: \n");
                novoPedido.Data = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Digite o nome do fornecedor: \n");
                novoPedido.Fornecedor = Console.ReadLine();
                pdDao.Alterar(novoPedido);
            }


        }
    }
   
}
