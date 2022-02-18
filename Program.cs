using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!
            // Armstrong Bezerra
            do
            {
                Console.WriteLine("Digite a Linha que deseja abrir: ");
                int linha = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite a Coluna que deseja abrir: ");
                int coluna = Convert.ToInt16(Console.ReadLine());
                campoMinado.Abrir(linha, coluna);
                Console.WriteLine(campoMinado.Tabuleiro);
                MensagemStatusJogo(campoMinado.JogoStatus);

            } 
            while (campoMinado.JogoStatus != 1 && campoMinado.JogoStatus != 2);

        }
        static void MensagemStatusJogo(int status)
        {
            switch (status)
            {
                case 1:
                    Console.WriteLine("Vitoria, você encontrou todas as casas que não possui bomba");
                    break;
                case 2:
                    Console.WriteLine("GameOver, você encontrou uma bomba");
                    break;
                default:
                    Console.WriteLine("Jogo em aberto, continue procurando as casas que não possuem bombas");
                    break;
            }
        }
    }
}
