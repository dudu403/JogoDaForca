namespace JogoDaForca.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavrasChaves = { "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJÁ", "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MAÇÃ", "MANGABA", "MANGA", "MARACUJÁ", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };

            Console.WriteLine("Bem-vindo ao Jogo da Forca!");

            Random random = new Random();
            string palavra = palavrasChaves[random.Next(0, palavrasChaves.Length)];

            char[] letrasAdivinhadas = new char[palavra.Length];
            int tentativasIncorretas = 0;

            while (tentativasIncorretas < 5)
            {
                Console.Clear();
                DesenehoDoBoneco(tentativasIncorretas);
                DesenhoDaPalavraNoConsole(letrasAdivinhadas);

                Console.Write("Digite sua letra: ");
                char letra = char.Parse(Console.ReadLine());

                if (palavra.Contains(letra))
                {
                    for (int i = 0; i < palavra.Length; i++)
                    {
                        if (palavra[i] == letra)
                        {
                            letrasAdivinhadas[i] = letra;
                        }
                    }
                }
                else
                {
                    tentativasIncorretas++;
                }

                if (new string(letrasAdivinhadas) == palavra)
                {
                    Console.Clear();
                    DesenehoDoBoneco(tentativasIncorretas);
                    DesenhoDaPalavraNoConsole(letrasAdivinhadas);
                    Console.WriteLine("Parabéns, você ganhou!");
                    Console.ReadLine();
                    return;
                }
            }

            Console.Clear();
            DesenehoDoBoneco(tentativasIncorretas);
            DesenhoDaPalavraNoConsole(letrasAdivinhadas);
            Console.WriteLine("Você perdeu! A palavra era " + palavra + ". Tente novamente.");
            Console.ReadLine();
        }

        static void DesenehoDoBoneco(int tentativasIncorretas)
        {
            Console.WriteLine(" ___");

            if (tentativasIncorretas >= 1)
            {
                Console.WriteLine("|   |");
                Console.WriteLine("|   O");
            }
            else
            {
                Console.WriteLine("|");
                Console.WriteLine("|");
            }

            if (tentativasIncorretas == 2)
            {
                Console.WriteLine("|   |");
            }
            else if (tentativasIncorretas == 3)
            {
                Console.WriteLine("|  /|");
            }
            else if (tentativasIncorretas >= 4)
            {
                Console.WriteLine("|  /|\\");
            }
            else
            {
                Console.WriteLine("|");
            }

            if (tentativasIncorretas == 5)
            {
                Console.WriteLine("|  /");
            }
            else if (tentativasIncorretas >= 6)
            {
                Console.WriteLine("|  / \\");
            }
            else
            {
                Console.WriteLine("|");
            }

            Console.WriteLine("|");
            Console.WriteLine("|__________");
            Console.WriteLine();
        }

        static void DesenhoDaPalavraNoConsole(char[] tentativasCorretas)
        {
            foreach (char tentativas in tentativasCorretas)
            {
                if (tentativas == '\0')
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(tentativas + " ");
                }
            }
        }
    }
}
