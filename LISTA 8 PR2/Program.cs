using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_8_PR2
{
    internal class Program
    {

        static void Main(string[] args)

        {
            public static void Exer1()
            {
                Console.WriteLine("será codifcado o exer1");


                int quantidadeProdut, quantidadeTotal = 0;
                float valorProdut, valorTotal = 0;


                do
                {
                    Console.WriteLine("escreva a quantidade de produtos:");
                    quantidadeProdut = int.Parse(Console.ReadLine());



                    if (quantidadeProdut == 0)
                    {
                        break;
                    }
                    Console.WriteLine("escreva o valor do produto");
                    valorProdut = float.Parse(Console.ReadLine());
                    valorTotal += quantidadeProdut * valorProdut;
                    quantidadeTotal += quantidadeProdut;

                    Console.WriteLine("A quantidade de itens :" + quantidadeTotal);
                    Console.WriteLine("O valor total :" + valorTotal);
                } while (quantidadeProdut > 0);



            }

            public static void Exer2()
            {
                Console.WriteLine("Aqui será codificado o exercício 2");

                string nomeProduto, nomeMaior = "", nomeMenor = "";
                int numeroItens, parada = 2;
                float precComp, maiorValor, menorValor, cont = 2, total;

                maiorValor = float.MinValue;
                menorValor = float.MaxValue;

                do
                {
                    Console.WriteLine("coloque o nome do produto:");
                    nomeProduto = Console.ReadLine();

                    Console.WriteLine("Entre com a quantidade:");
                    numeroItens = int.Parse(Console.ReadLine());

                    Console.WriteLine("entre com  preço unitário:");
                    precComp = float.Parse(Console.ReadLine());

                    total = numeroItens * precComp;

                    if (total > maiorValor)
                    {
                        maiorValor = total;
                        nomeMaior = nomeProduto;

                    }

                    if (total > maiorValor)
                    {
                        menorValor = total;
                        nomeMenor = nomeProduto;

                    }

                    Console.WriteLine("escreva 1 para sair ou 2 para continuar");
                    parada = int.Parse(Console.ReadLine());


                } while (parada != 1);

                Console.WriteLine("Maior quantia investida {0} no produto {1}:", maiorValor, nomeMaior);
                Console.WriteLine("Menor quantia investida {0} no produto {1}:", menorValor, nomeMenor);
                Console.ReadKey();

            }

            public static void Exer3()
            {
                Console.WriteLine("Aqui será codifcado o exercício 1");
                int i;
                int avaliacoes;
                float pesos, totalpeso = 0;
                Console.WriteLine("escreva a quantidade de avaliações:");
                avaliacoes = int.Parse(Console.ReadLine());

                p = 0;
                do
                {
                    Console.WriteLine("escreva os pesos das avaliacoes:");
                    pesos = int.Parse(Console.ReadLine());
                    totalpeso += pesos;
                    i++;
                } while (p <= avaliacoes);
                {

                }

                if (totalpeso < 100)
                    Console.WriteLine("não foi alcançada  porcentagem desejada");

                else if (totalpeso > 100)
                    Console.WriteLine("foi ultrapassada  porcentagem de 100%");

                else

                    Console.WriteLine("porcentagem de pesos alcançada");

            }

            public static void Exer4()
            {
                Console.WriteLine(" será codifcado o exercício 1");

                string sigla;

                Console.WriteLine("escreva a sigla de um estado brasileiro");
                Console.WriteLine("---menu---");
                Console.WriteLine("---sp---");
                Console.WriteLine("---rj---");
                Console.WriteLine("---go---");




                sigla = Console.ReadLine();
                switch (sigla)

                {

                    case "sp":
                        Console.WriteLine("essa sigla pertence ao estado de são paulo ");
                        break;

                    case "rj":
                        Console.WriteLine("essa sigla pertence ao estado de rio de janeiro");
                        break;

                    case "go":
                        Console.WriteLine("essa sigla pertence ao estado de goiás");
                        break;

                    default:
                        Console.WriteLine("esse estado não está no nosso menu");
                        break;

                }
            }

            public static void Exer5()
            {
                Console.WriteLine(" será codifcado o exercício 1");

                int mes, data;

                Console.WriteLine("Escolha um mês:");

                Console.WriteLine("-----MENU-----");
                Console.WriteLine("1- Janeiro");
                Console.WriteLine("2- fevereiro");
                Console.WriteLine("3- março");
                Console.WriteLine("4- abril");
                Console.WriteLine("5- maio");
                Console.WriteLine("6- junho");
                Console.WriteLine("7- julho");
                Console.WriteLine("8- agosto");
                Console.WriteLine("9- setembro");
                Console.WriteLine("10- outubro");
                Console.WriteLine("11- novembro");
                Console.WriteLine("12- dezembro");
                mes = int.Parse(Console.ReadLine());


                switch (mes)
                {
                    case 1:
                        Console.WriteLine(" estação  é verão");

                        break;

                    case 2:
                        Console.WriteLine(" estação do mês de fevereiro é Verão");
                        break;

                    case 3:
                        Console.WriteLine("escreva a data:");
                        data = int.Parse(Console.ReadLine());

                        if (data < 21)
                            Console.WriteLine(" estação é verão");

                        else
                            Console.WriteLine(" estação é outono");
                        break;


                    case 4:
                        Console.WriteLine(" estação do mês de abril é Outono");
                        break;

                    case 5:
                        Console.WriteLine(" estação do mês de Maio é Outono");
                        break;


                    case 6:
                        Console.WriteLine("escreva  a data:");
                        data = int.Parse(Console.ReadLine());

                        if (data < 21)
                            Console.WriteLine(" estação é outono");

                        else
                            Console.WriteLine(" estação é inverno");
                        break;


                    case 7:
                        Console.WriteLine(" estaçao do mês de julho é inverno");
                        break;

                    case 8:
                        Console.WriteLine("estaçao do mês de agosto é inverno");
                        break;

                    case 9:
                        Console.WriteLine("escreva a data:");
                        data = int.Parse(Console.ReadLine());

                        if (data < 23)
                            Console.WriteLine(" estação é inverno");

                        else
                            Console.WriteLine(" estação é primavera");
                        break;


                    case 10:
                        Console.WriteLine(" estaçao do mês de outubro é primavera");
                        break;

                    case 11:
                        Console.WriteLine(" estaçao do mês de novembro é primavera");
                        break;

                    case 12:
                        Console.WriteLine("escreva a data:");
                        data = int.Parse(Console.ReadLine());


                        if (data < 21)

                            Console.WriteLine("estação é primavera");

                        else
                            Console.WriteLine("estação é verão");
                        break;

                    default:
                        Console.WriteLine(" opção não corresponde a nenhum mês do ano");
                        break;

                }

            }

            public static void Exer6()
            {
                Console.WriteLine(" será codifcado o exercício 1");

                float peso, altura, imc;
                Console.WriteLine("escreva seu peso:");
                peso = float.Parse(Console.ReadLine());
                Console.WriteLine("escreva sua altura");
                altura = float.Parse(Console.ReadLine());

                imc = peso / (altura * altura);

                if (peso < 18.5)
                {

                    Console.WriteLine("Abaixo do peso");
                }

                else if (peso > 18.5 && peso < 24.9)
                {

                    Console.WriteLine("Peso normal");
                }

                else if (peso > 25.0 && peso < 29.9)
                {

                    Console.WriteLine("Sobre peso");
                }

                else if (peso > 30.0 && peso < 34.9)
                {

                    Console.WriteLine("Obesidade grau 1");
                }


                else if (peso > 35.0 && peso < 39.9)
                {

                    Console.WriteLine("Obesidade grau 2");
                }

                else if (peso > 40.0)
                {

                    Console.WriteLine("obesidade grau 3 (mórbida).");
                }

            }

            public static void Exer7()
            {
                Console.WriteLine("Aqui será codifcado o exercício 1");

                int p;
                float numero;

                Console.WriteLine("digite um numero maior que zero:");
                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Divisores de " + numero + ":");
                p = 1;
                do
                {
                    if (numero % p == 0)
                    {
                        Console.WriteLine(p);
                    }
                    p++;
                } while (p <= numero);


            }

            static void Main(string[] args)
            {

                int exercicio;
                int p = 1;

                do
                {


                    Console.WriteLine("Escolha um mês:");
                    Console.WriteLine("----MENU----");
                    Console.WriteLine("exercicio 1 - digite1");
                    Console.WriteLine("exercicio 2 - digite2");
                    Console.WriteLine("exercicio 3 - digite3");
                    Console.WriteLine("exercicio 4 - digite4");
                    Console.WriteLine("exercicio 5 - digite5");
                    Console.WriteLine("exercicio 6 - digite6");
                    Console.WriteLine("exercicio 7 - digite7");

                    exercicio = int.Parse(Console.ReadLine());


                    switch (exercicio)
                    {

                        case 1:
                            Exer1();
                            break;


                        case 2:
                            Exer2();
                            break;


                        case 3:
                            Exer3();
                            break;


                        case 4:
                            Exer4();
                            break;



                        case 5:
                            Exer5();
                            break;

                        case 6:
                            Exer6();
                            break;


                        case 7:
                            Exer7();
                            break;






                    }

                    Console.WriteLine("escreva  o valor 0 para parar ou qualquer outro para continuar");
                    p = int.Parse(Console.ReadLine());
                } while (p != 0);

            }
        }
    }
}




