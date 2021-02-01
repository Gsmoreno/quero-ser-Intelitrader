using System;

namespace Dojo_Livraria_do_Harry_Potter {
    class Program {
        static void Main (string[] args) {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine ("___________.Bem Vindo(a) Livraria do Harry Potter.____________");
            Console.ResetColor ();

            double livro = 42.00;
            double desconto;
            double quantidade;
            double pf, cs, pa, cf, of , ep, rm;

            System.Console.WriteLine ("Quantas copias de Pedra Filosofal você quer:");
            pf = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Quantas copias de Câmara Secreta você quer:");
            cs = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Quantas copias de Prisioneiro de Azkaban você quer:");
            pa = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Quantas copias de Cálice de Fogo você quer:");
            cf = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Quantas copias de Ordem da Fênix você quer:"); 
            of = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Quantas copias de Enigma do Príncipe você quer:");
            ep = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Quantas copias de Relíquias da Morte você quer:");
            rm = double.Parse (Console.ReadLine ());

            

                //=========================================== Pedra Filosofal========================================================
                if (pf == 2) {
                    quantidade = livro * 2;
                    desconto = quantidade * (1 - 0.05);
                    System.Console.WriteLine ("O valor que você ira pagar em Pedra Filosofal é de:" + desconto);
                } else if (pf == 3) {
                    quantidade = livro * 3;
                    desconto = quantidade * (1 - 0.10);
                    System.Console.WriteLine ("O valor que você ira pagar em Pedra Filosofal é de:" + desconto);
                } else if (pf == 4) {
                    quantidade = livro * 4;
                    desconto = quantidade * (1 - 0.15);
                    System.Console.WriteLine ("O valor que você ira pagar em Pedra Filosofal é de:" + desconto);
                } else if (pf == 5) {
                    quantidade = livro * 5;
                    desconto = quantidade * (1 - 0.20);
                    System.Console.WriteLine ("O valor que você ira pagar em Pedra Filosofal é de:" + desconto);
                }else if( pf < 0 || pf > 5){
                    System.Console.WriteLine(" O maximo de livros que vendemos são 5 e o minimo são 0");
                }
                

            // ==============================================Câmara Secreta==============================================================
                if (cs == 2) {
                    quantidade = livro * 2;
                    desconto = quantidade * (1 - 0.05);
                    System.Console.WriteLine ("O valor que você ira pagar em Câmara Secreta é de:" + desconto);
                } else if (cs == 3) {
                    quantidade = livro * 3;
                    desconto = quantidade * (1 - 0.10);
                    System.Console.WriteLine ("O valor que você ira pagar em Câmara Secreta é de:" + desconto);
                } else if (cs == 4) {
                    quantidade = livro * 4;
                    desconto = quantidade * (1 - 0.15);
                    System.Console.WriteLine ("O valor que você ira pagar em Câmara Secreta é de:" + desconto);
                } else if (cs == 5) {
                    quantidade = livro * 5;
                    desconto = quantidade * (1 - 0.20);
                    System.Console.WriteLine ("O valor que você ira pagar em Câmara Secreta é de:" + desconto);
                }else if( cs < 0 || cs > 5){
                    System.Console.WriteLine(" O maximo de livros que vendemos são 5 e o minimo são 0");
                }

                // ==============================================Prisioneiro de Azkaban==============================================================
                if (pa == 2) {
                    quantidade = livro * 2;
                    desconto = quantidade * (1 - 0.05);
                    System.Console.WriteLine ("O valor que você ira pagar em Prisioneiro de Azkaban é de:" + desconto);
                } else if (pa == 3) {
                    quantidade = livro * 3;
                    desconto = quantidade * (1 - 0.10);
                    System.Console.WriteLine ("O valor que você ira pagar em Prisioneiro de Azkaban é de:" + desconto);
                } else if (pa == 4) {
                    quantidade = livro * 4;
                    desconto = quantidade * (1 - 0.15);
                    System.Console.WriteLine ("O valor que você ira pagar em Prisioneiro de Azkaban é de:" + desconto);
                } else if (pa == 5) {
                    quantidade = livro * 5;
                    desconto = quantidade * (1 - 0.20);
                    System.Console.WriteLine ("O valor que você ira pagar em Prisioneiro de Azkaban é de:" + desconto);
                }else if( pa < 0 || pa > 5){
                    System.Console.WriteLine("O maximo de livros que vendemos são 5 e o minimo são 0");
                }

                // ==============================================Cálice de Fogo==============================================================
                if (cf == 2) {
                    quantidade = livro * 2;
                    desconto = quantidade * (1 - 0.05);
                    System.Console.WriteLine ("O valor que você ira pagar em Cálice de Fogo é de:" + desconto);
                } else if (cf == 3) {
                    quantidade = livro * 3;
                    desconto = quantidade * (1 - 0.10);
                    System.Console.WriteLine ("O valor que você ira pagar em Cálice de Fogo é de:" + desconto);
                } else if (cf == 4) {
                    quantidade = livro * 4;
                    desconto = quantidade * (1 - 0.15);
                    System.Console.WriteLine ("O valor que você ira pagar em Cálice de Fogo é de:" + desconto);
                } else if (cf == 5) {
                    quantidade = livro * 5;
                    desconto = quantidade * (1 - 0.20);
                    System.Console.WriteLine ("O valor que você ira pagar em Cálice de Fogo é de:" + desconto);
                }else if( cf < 0 || cf > 5){
                    System.Console.WriteLine("O maximo de livros que vendemos são 5 e o minimo são 0");
                }

                // ==============================================Ordem da Fênix==============================================================
                if (of == 2) {
                    quantidade = livro * 2;
                    desconto = quantidade * (1 - 0.05);
                    System.Console.WriteLine ("O valor que você ira pagar em Ordem da Fênix é de:" + desconto);
                } else if (of == 3) {
                    quantidade = livro * 3;
                    desconto = quantidade * (1 - 0.10);
                    System.Console.WriteLine ("O valor que você ira pagar em Ordem da Fênix é de:" + desconto);
                } else if (of == 4) {
                    quantidade = livro * 4;
                    desconto = quantidade * (1 - 0.15);
                    System.Console.WriteLine ("O valor que você ira pagar em Ordem da Fênix é de:" + desconto);
                } else if (of == 5) {
                    quantidade = livro * 5;
                    desconto = quantidade * (1 - 0.20);
                    System.Console.WriteLine ("O valor que você ira pagar em Ordem da Fênix é de:" + desconto);
                }else if( of < 0 || of > 5){
                    System.Console.WriteLine("O maximo de livros que vendemos são 5 e o minimo são 0");
                }

                // ==============================================Enigma do Príncipe==============================================================
                if (ep == 2) {
                    quantidade = livro * 2;
                    desconto = quantidade * (1 - 0.05);
                    System.Console.WriteLine ("O valor que você ira pagar em Enigma do Príncipe é de:" + desconto);
                } else if (ep == 3) {
                    quantidade = livro * 3;
                    desconto = quantidade * (1 - 0.10);
                    System.Console.WriteLine ("O valor que você ira pagar em Enigma do Príncipe é de:" + desconto);
                } else if (ep == 4) {
                    quantidade = livro * 4;
                    desconto = quantidade * (1 - 0.15);
                    System.Console.WriteLine ("O valor que você ira pagar em Enigma do Príncipe é de:" + desconto);
                } else if (ep == 5) {
                    quantidade = livro * 5;
                    desconto = quantidade * (1 - 0.20);
                    System.Console.WriteLine ("O valor que você ira pagar em Enigma do Príncipe é de:" + desconto);
                }else if( ep < 0 || ep > 5){
                    System.Console.WriteLine("O maximo de livros que vendemos são 5 e o minimo são 0");
                }

                // ==============================================Relíquias da Morte==============================================================
                if (rm == 2) {
                    quantidade = livro * 2;
                    desconto = quantidade * (1 - 0.05);
                    System.Console.WriteLine ("O valor que você ira pagar em Relíquias da Morte é de:" + desconto);
                } else if (rm == 3) {
                    quantidade = livro * 3;
                    desconto = quantidade * (1 - 0.10);
                    System.Console.WriteLine ("O valor que você ira pagar em Relíquias da Morte é de:" + desconto);
                } else if (rm == 4) {
                    quantidade = livro * 4;
                    desconto = quantidade * (1 - 0.15);
                    System.Console.WriteLine ("O valor que você ira pagar em Relíquias da Morte é de:" + desconto);
                } else if (rm == 5) {
                    quantidade = livro * 5;
                    desconto = quantidade * (1 - 0.20);
                    System.Console.WriteLine ("O valor que você ira pagar em Relíquias da Morte é de:" + desconto);
                }else if( rm < 0 || rm > 5){
                    System.Console.WriteLine(" O maximo de livros que vendemos são 5 e o minimo são 0");
                }
            
            

        }
    }
}