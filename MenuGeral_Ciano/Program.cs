namespace MenuGeral_Ciano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;

            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("Menu principal");
                Console.WriteLine("[1] Todos os Cálculos");
                Console.WriteLine("[2] Entrevista");
                Console.WriteLine("[3] Compara Números");
                Console.WriteLine("[4] Menu Cálculos");
                Console.WriteLine("[5] Par ou Ímpar");
                Console.WriteLine("[6] Menu Triângulos");
                Console.WriteLine("[7] Tabuada");
                Console.WriteLine("[8] Analisa 10 Números");
                Console.WriteLine("[9] Jogo Adivinha Número");
                Console.WriteLine("[10] IMC");
                Console.WriteLine("[11] Bhaskara");
                Console.WriteLine("[12] Encerrar Programa");
                Console.WriteLine("Digite sua opção:");
                opc = int.Parse(Console.ReadLine());




                switch (opc)
                {


                    case 1:
                        {
                            TodosCalculos();
                            break;
                        }
                    case 2:
                        {
                            Entrevista();
                            break;
                        }
                    case 3:
                        {
                            ComparaNumeros();
                            break;
                        }
                    case 4:
                        {
                            MenuCalculos();
                            break;
                        }
                    case 5:
                        {
                            ParImpar();
                            break;
                        }
                    case 6:
                        {
                            Triangulos();
                            break;
                        }
                    case 7:
                        {
                            Tabuada();
                            break;

                        }
                    case 8:
                        {
                            AnalisaNumeros();
                            break;
                        }
                    case 9:
                        {
                            JogoAdivinha();
                            break;
                        }
                    case 10:
                        {
                            IMC();
                            break;
                        }
                    case 11:
                        {
                            Bhaskara();
                            break;
                        }
                    case 12:
                        {
                            Console.Write("Tchau");
                            break;
                        }

                }

            } while (opc != 12);
        }
        static void TodosCalculos()
        {

            float x, y, z;
            string resp;


            do
            {
                Console.Clear();
                Console.WriteLine("Escreva um número ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva outro número ");
                y = int.Parse(Console.ReadLine());


                z = x + y;

                Console.WriteLine("A soma entre os números é " + z);


                z = x - y;

                Console.WriteLine("A subtração entre os números é " + z);


                z = x * y;

                Console.WriteLine("A multiplicação entre os números é " + z);


                z = x / y;

                Console.WriteLine("A divisão entre os números é " + z);




                Console.Write("Deseja Continuar?(s|n): ");
                resp = Console.ReadLine();

            } while (resp.ToUpper() == "S" || resp.ToUpper() == "SIM");





        }

        static void Entrevista()
        {
            string nome, casa, estudo, filho, resposta;



            do
            {
                int filhos = 0, anon, anoa, idade, mesn, mesa, idadeb;

                Console.Clear();

                Console.WriteLine("Olá, responda as seguintes perguntas: ");

                Console.WriteLine("Qual é seu nome? ");
                nome = Console.ReadLine();

                Console.WriteLine("Onde você mora? ");
                casa = Console.ReadLine();

                Console.WriteLine("Onde você estuda? ");
                estudo = Console.ReadLine();

                Console.WriteLine("Tem filhos?(s|n) ");
                filho = Console.ReadLine();


                if (filho == "s")
                {
                    Console.WriteLine("Quantos? ");
                    filhos = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Em qual ano você nasceu? ");
                anon = int.Parse(Console.ReadLine());

                Console.WriteLine("Em qual mês você nasceu?(numeral) ");
                mesn = int.Parse(Console.ReadLine());

                Console.WriteLine("Em qual ano estamos? ");
                anoa = int.Parse(Console.ReadLine());

                Console.WriteLine("Em qual mês estamos?(numeral) ");
                mesa = int.Parse(Console.ReadLine());



                Console.WriteLine("Agora sei que seu nome é " + nome + ", que mora em " + casa + ", que estuda em " + estudo + ".");

                if (filho == "s")

                {
                    Console.WriteLine(" Também sei que você tem " + filhos + " filhos.");

                }
                else

                {
                    Console.WriteLine(" Também sei que você não tem filhos.");

                }

                idade = anoa - anon;

                if (mesa < mesn)

                {
                    idadeb = idade - 1;
                    Console.WriteLine(" Além disso, sei que você tem " + idadeb + " anos completos.");

                }
                else

                {
                    Console.WriteLine(" Além disso, sei que você tem " + idade + " anos completos.");

                }


                Console.WriteLine("Deseja repetir?(s|n) ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");

        }

        static void ComparaNumeros()
        {
            int a, b;
            string resposta;

            do
            {
                Console.Clear();
                Console.WriteLine("Informe o primeiro número: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o segundo número: ");
                b = int.Parse(Console.ReadLine());


                if (a > b)
                {
                    Console.WriteLine("O primeiro número (" + a + ") é maior que o segundo número (" + b + ")");

                }

                if (a < b)
                {
                    Console.WriteLine("O primeiro número (" + a + ") é menor que o segundo número (" + b + ")");

                }

                if (a == b)
                {
                    Console.WriteLine("O primeiro número (" + a + ") é igual ao segundo número (" + b + ")");

                }

                Console.WriteLine("Deseja repetir?(s|n) ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");
        }

        static void MenuCalculos()
        {
            string operacao, operacaob, resposta;
            double x, y, z;

            do
            {
                Console.Clear();
                Console.WriteLine("Qual operação você deseja fazer? ");

                Console.WriteLine("=============================================");

                Console.WriteLine("i - Escrever números");

                Console.WriteLine("+ - Adiçao");
                Console.WriteLine("- - Subtração");

                Console.WriteLine("x - Multiplicação");

                Console.WriteLine("/ - Divisão");

                Console.WriteLine("f - Finalizar programa");

                Console.WriteLine("=============================================");

                Console.WriteLine("Digite sua opção: ");

                operacao = Console.ReadLine();





                switch (operacao)

                {
                    case "i":
                        {
                            Console.WriteLine("Escreva um número ");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Escreva outro número ");
                            y = int.Parse(Console.ReadLine());

                            Console.WriteLine("Agora escolha uma operação do menu: ");
                            operacaob = Console.ReadLine();

                            switch (operacaob)
                            {
                                case "+":
                                    {
                                        z = x + y;
                                        Console.WriteLine("A soma entre os números é " + z);
                                        break;

                                    }
                                case "-":
                                    {
                                        z = x - y;
                                        Console.WriteLine("A subtração entre os números é " + z);
                                        break;

                                    }
                                case "x":
                                    {
                                        z = x * y;

                                        Console.WriteLine("A multiplicação entre os números é " + z);


                                        break;

                                    }
                                case "/":
                                    {
                                        z = x / y;

                                        Console.WriteLine("A divisão entre os números é " + z);


                                        break;

                                    }
                                case "f":
                                    {
                                        Console.WriteLine("tchau");

                                        break;

                                    }

                                default:
                                    {
                                        Console.WriteLine("Opção inválida");
                                        break;

                                    }
                            }
                            break;

                        }
                    case "+":
                        {
                            Console.WriteLine("Escreva um número ");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Escreva outro número ");
                            y = int.Parse(Console.ReadLine());

                            z = x + y;

                            Console.WriteLine("A soma entre os números é " + z);
                            break;

                        }
                    case "-":
                        {
                            Console.WriteLine("Escreva um número ");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Escreva outro número ");
                            y = int.Parse(Console.ReadLine());

                            z = x - y;

                            Console.WriteLine("A subtração entre os números é " + z);


                            break;

                        }
                    case "x":
                        {
                            Console.WriteLine("Escreva um número ");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Escreva outro número ");
                            y = int.Parse(Console.ReadLine());

                            z = x * y;

                            Console.WriteLine("A multiplicação entre os números é " + z);


                            break;

                        }
                    case "/":
                        {
                            Console.WriteLine("Escreva um número ");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Escreva outro número ");
                            y = int.Parse(Console.ReadLine());

                            z = x / y;

                            Console.WriteLine("A divisão entre os números é " + z);


                            break;

                        }
                    case "f":
                        {
                            Console.WriteLine("tchau\n");

                            break;

                        }

                    default:
                        {
                            Console.WriteLine("Opção inválida");
                            break;

                        }




                }

                Console.WriteLine("Deseja repetir?(s|n) ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");
        }

        static void ParImpar()
        {
            string resposta;
            int numero;

            do
            {
                Console.Clear();
                Console.WriteLine("Escreva um número ");
                numero = int.Parse(Console.ReadLine());


                if (numero % 2 == 0)

                {
                    Console.WriteLine("Este número é par");

                }
                else
                {
                    Console.WriteLine("Este número é ímpar");
                }


                Console.WriteLine("Deseja repetir?(s|n) ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");
        }

        static void Triangulos()
        {
            float ladoa, ladob, ladoc, altura, somaa, subtracaoa, somab, subtracaob, somac, subtracaoc, absolutoa, absolutob, absolutoc, resultado, resultadob;
            string resposta;

            do

            {
                Console.Clear();
                Console.WriteLine("Descubra a área e a classificação do seu triângulo:");

                Console.WriteLine("-----------------------------------------------------");


                Console.WriteLine("Digite o valor da base: ");

                ladoa = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor do outro lado: ");

                ladob = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor do outro lado: ");

                ladoc = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da altura: ");

                altura = int.Parse(Console.ReadLine());


                somaa = ladob + ladoc;

                subtracaoa = ladob - ladoc;

                absolutoa = Math.Abs(subtracaoa);


                if (ladoa > absolutoa && ladoa < somaa)

                {
                    somab = ladoa + ladoc;

                    subtracaob = ladoa - ladoc;

                    absolutob = Math.Abs(subtracaob);


                    if (ladob > absolutob && ladob < somab)

                    {
                        somac = ladoa + ladob;

                        subtracaoc = ladoa - ladob;

                        absolutoc = Math.Abs(subtracaoc);


                        if (ladoc > absolutoc && ladob < somac)

                        {
                            resultado = ladoa * altura;

                            resultadob = resultado / 2;


                            if (ladoa == ladob && ladoc == ladob && ladoa == ladoc)

                            {
                                Console.WriteLine("Esse triângulo possui " + resultadob + " de área e é um triângulo Equilátero");

                            }
                            else if (ladoa == ladob || ladoa == ladoc || ladob == ladoc)
                            {
                                Console.WriteLine("Esse triângulo possui " + resultadob + " de área e é um triângulo Isósceles");

                            }
                            if (ladoa != ladob && ladoa != ladoc && ladob != ladoc)

                            {
                                Console.WriteLine("Esse triângulo possui " + resultadob + " de área e é um triângulo Escaleno");

                            }

                        }
                    }

                }
                else

                {
                    Console.WriteLine("Não é um triângulo");

                }

                Console.WriteLine("Deseja repetir?(s|n) ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");
        }

        static void Tabuada()
        {
            int numero, tab, i;
            string resp;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(30, 0);
                Console.WriteLine("Tabuadas");
                Console.SetCursorPosition(27, 1);
                Console.WriteLine("=====================");
                Console.Write("Qual tabuada você gostaria de acessar? ");
                numero = int.Parse(Console.ReadLine());
                Console.Write("Essa é a tabuada do número " + numero + "\n");

                for (i = 1; i <= 10; i++)
                {
                    tab = i * numero;
                    Console.WriteLine(numero + " x " + i + " = " + tab);
                }

                Console.Write("Deseja Continuar?(s|n): ");
                resp = Console.ReadLine();

            } while (resp.ToUpper() == "S" || resp.ToUpper() == "SIM");

        }
        static void AnalisaNumeros()
        {
            string resp;

            do
            {
                int n, i = 1, contpar = 0, maior = 0, contimpar, menor = 151165156, posmaior = 0, posmenor = 0;
                float media, total = 0;

                Console.Clear();
                Console.SetCursorPosition(30, 0);
                Console.WriteLine("Analisa 10 Números");
                Console.SetCursorPosition(27, 1);
                Console.WriteLine("=====================");

                do
                {
                    Console.Write("Informe o " + i + "º número: ");
                    n = int.Parse(Console.ReadLine());

                    i++;

                    total = total + n;
                    if (n % 2 == 0)
                    {
                        contpar++;
                    }
                    if (n > maior)
                    {
                        maior = n;
                        posmaior = i - 1;

                    }
                    if (n < menor)
                    {
                        menor = n;
                        posmenor = i - 1;

                    }
                } while (i <= 10);

                media = total / 10;
                contimpar = 10 - contpar;

                Console.WriteLine("O total é " + total);
                Console.WriteLine("Foram digitados " + contpar + " números pares e " + contimpar + " números ímpares");
                Console.WriteLine("O maior número é " + maior + " e o menor é " + menor);
                Console.WriteLine("O maior número está na " + posmaior + "º posição e o menor está na " + posmenor + "º posição");
                Console.WriteLine("A média é " + media);

                Console.WriteLine("Deseja continuar?(s|n) ");
                resp = Console.ReadLine();

            } while (resp == "s");
        }
        static void JogoAdivinha()
        {
            int contador = 1, a;
            Random sorteado = new Random();
            int numerosorteado;
            string resposta;

            do

            {


                Console.Clear();
                numerosorteado = sorteado.Next(1, 10);

                do

                {
                    Console.WriteLine("Chute um número de um a dez: ");
                    a = int.Parse(Console.ReadLine());




                    if (a < numerosorteado)

                    {
                        Console.WriteLine("O número sorteado é maior, tente de novo");

                        contador++;

                    }
                    else if (a > numerosorteado)
                    {
                        Console.WriteLine("O número sorteado é menor, tente de novo");

                        contador++;

                    }

                }
                while (numerosorteado != a);



                Console.WriteLine("Parabéns você acertou, foram " + contador + " tentativas");


                Console.WriteLine("Deseja repetir?(s/n) ");

                resposta = Console.ReadLine();



                if (resposta == "s")

                {
                    contador = 1;

                }

            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");

        }

        static void IMC()
        {
            double peso, altura, imc;

            string resposta;

            do

            {
                Console.Clear();
                Console.WriteLine("Qual é seu peso? ");

                peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual é sua altura? ");

                altura = double.Parse(Console.ReadLine());



                imc = peso / (altura * altura);




                Console.WriteLine("Seu IMC é " + imc + ", portanto ");



                    if (imc >= 18.5 && imc <= 24.9)

                    {
                        Console.WriteLine("você está no peso ideal ");

                    }
                    else if (imc >= 25 && imc <= 29.9)
                    {
                        Console.WriteLine("você está com sobrepeso");

                    }
                    else if (imc >= 30 && imc <= 39.9)
                    {
                        Console.WriteLine("voce está obeso ");

                    }
                    else if (imc >= 40)
                    {
                        Console.WriteLine("você tem obesidade grave ");

                    }
                    else

                    {
                        Console.WriteLine("você está abaixo do peso ");

                    }
                

                Console.WriteLine("Deseja repetir?(s|n) ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");
        }

        static void Bhaskara()
        {
            double ca, cb, cc, delta, conjunto, b, raiz, cbnegativo, linha1p, linha1n, linha2, resultado1, resultado2;

            string resposta;


            do

            {
                Console.Clear();
                Console.WriteLine("Digite o coeficiente a: ");
                ca = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o coeficiente b: ");
                cb = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o coeficiente c: ");
                cc = double.Parse(Console.ReadLine());


                conjunto = -4 * ca * cc;

                b = cb * cb;

                delta = b + conjunto;


                raiz = Math.Sqrt(delta);


                linha2 = ca * 2;

                cbnegativo = -1 * cb;


                linha1p = cbnegativo + raiz;

                linha1n = cbnegativo - raiz;


                resultado1 = linha1p / linha2;

                resultado2 = linha1n / linha2;

                Console.WriteLine("O resultado 1 é " + resultado1);

                Console.WriteLine("O resultado 2 é " + resultado2);
                Console.WriteLine("Deseja repetir?(s|n) ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");
        }
    }
}