using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_sa_TP3
{
    class Metodos
    {
        public static void InserirPessoaLista(List<Lista> _listAniversario, Lista lista)
        {
            //recuperando lista que foi passada como parametro
            List<Lista> _list = _listAniversario;

            //Adiconando nova pessoa à lista
            _list.Add(lista);

            //Carregando menu principal
            Metodos.CarregarMenuPrincipal();

            //Guarda o valor digitado pelo usuario
            string _menu = Console.ReadLine().ToString();

            //Realiza ação de acorodo com a opção escolhida pelo usuario
            Metodos.MenuOpcoes(_listAniversario, _menu);
        }



        public static void ConsultarLista(List<Lista> _listAniversario)
        {

            //Carregando menu principal
            Metodos.CarregarMenuPrincipal();

            //Recuperando menu digitado pela pessoa
            string _menu = Console.ReadLine().ToString();

            //Carregando menu correspodente
            Metodos.MenuOpcoes(_listAniversario, _menu);
        }
        public static void MenuOpcoes(List<Lista> _listAniversario, string _menu)
        {
            switch (_menu)
            {
                case "1":
                    Console.WriteLine("Digite o nome da pessoa a ser inserida.");
                    string _nome = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Digite o sobrenome da pessoa a ser inserida.");
                    string _sobrenome = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Digite a data de nascimento da pessoa a ser inserida no formato (dd/mm/aaaa):");
                    string _dataNascimento = Console.ReadLine();
                    Console.WriteLine();


                    Console.WriteLine("Os dados abaixo estão corretos?");
                    Console.WriteLine("Nome completo: " + _nome + " " + _sobrenome);
                    Console.WriteLine("Data de nascimento: " + _dataNascimento);
                    Console.WriteLine();
                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("2 - Não");


                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Pessoa inserida com sucesso");
                        Console.WriteLine();
                        Metodos.InserirPessoaLista(_listAniversario, new Lista(_nome, _sobrenome, _dataNascimento));
                    }
                    else
                    {
                        string var;

                        Metodos.CarregarMenuPrincipal();
                        var = Console.ReadLine();
                        Metodos.MenuOpcoes(new List<Lista>(), var);
                        Console.ReadKey();

                    }



                    break;

                case "2":
                    //Visualizando lista


                    Console.WriteLine("Digite o nome ou parte do nome a ser pesquisado:");
                    var termo = Console.ReadLine();

                    Console.WriteLine();
                    var resultados = _listAniversario.Where(t => t.Nome.Contains(termo) || t.Sobrenome.Contains(termo));
                    foreach (var item in resultados)
                    {

                        DateTime aniv = new DateTime(DateTime.Now.Date.Year, item.DataNascimento.Month, item.DataNascimento.Day);
                        DateTime dia = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day);
                        TimeSpan anos = aniv - dia;
                        int ano = anos.Days;





                        if ((item.DataNascimento.Date.Month > DateTime.Now.Date.Month || item.DataNascimento.Date.Month == DateTime.Now.Date.Month)
                            && item.DataNascimento.Date.Day > DateTime.Now.Date.Day)

                        {
                            Console.WriteLine("Dados da pesquisa:");
                            Console.WriteLine();
                            Console.WriteLine("Nome completo: " + item.Nome + " " + item.Sobrenome);
                            Console.WriteLine("Data de nascimento: " + item.DataNascimento.Date.ToShortDateString());
                            Console.WriteLine("Faltam " + (ano) + " dias para o aniversário!");
                            Console.WriteLine();

                        }
                        else
                        {
                            Console.WriteLine("Dados da pesquisa:");
                            Console.WriteLine();
                            Console.WriteLine("Nome completo: " + item.Nome + " " + item.Sobrenome);
                            Console.WriteLine("Data de nascimento: " + item.DataNascimento.ToShortDateString());
                            Console.WriteLine("Já fez aniversário este ano!");
                            Console.WriteLine();

                        }




                    }

                    Metodos.ConsultarLista(_listAniversario);



                    break;

                case "3":
                    Console.WriteLine("Fechando programa!!!");
                    break;

                default:
                    Console.WriteLine("Operação Inválida!");

                    break;


            }
        }

        //Carregar MenuPrincipal
        public static void CarregarMenuPrincipal()
        {
            Console.WriteLine("Gerenciamento de Aniversario");
            Console.WriteLine();
            Console.WriteLine("Escolha a operação a ser realizada\n" +
                              "1 - Inserir pessoa \n" +
                              "2 - Consultar lista\n" +
                              "3 - Fechar aplicão");
        }
    }

    public class Lista
    {
        public string Nome, Sobrenome;
        public DateTime DataNascimento;
        public int Idade;

        private string _nome;
        private string _sobrenome;
        private DateTime _dataNascimento;



        public Lista(string nome, string sobrenome, string dataNascimento)
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _dataNascimento = Convert.ToDateTime(dataNascimento);

            Nome = _nome;
            Sobrenome = _sobrenome;
            DataNascimento = _dataNascimento.Date;

        }



    }
}
