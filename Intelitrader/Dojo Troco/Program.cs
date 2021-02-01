using System;

namespace Dojo_Troco
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------------BemVindo(a) ao Caixa Eletronico --------- XD");
            Console.ResetColor();

           int t100,t50,t10,t5,t1,m5,m25,m10,m05,m1;
            double pago,troco,produ,falt;

            troco = 0.0;
            produ = 0.0;
            pago = 0.0;
            falt = 0.0;
            t100 = 0;
            t50 = 0;
            t10 = 0;
            t5 = 0;
            t1 = 0;
            m5 = 0;
            m25 = 0;
            m10 = 0;
            m05 = 0;
            m1 = 0;
            

            Console.WriteLine("Digite o valor do produto:");
            produ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o pagamento");
            pago = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            

            if (produ > pago)
            {
                falt = produ - pago;
                Console.WriteLine("Valor a ser pago: R$ {0}", produ);
                Console.WriteLine("Valor pago: R$ {0}", pago);
                Console.WriteLine("Faltam: R$ {0}",falt);
            }

            else if (produ == pago)
            {
                Console.WriteLine("Valor a ser pago: R$ {0}", produ);
                Console.WriteLine("Valor pago: R$ {0}", pago);
                Console.WriteLine("Não existe troco!");
            }

            else
                troco = pago - produ;
            { 
                while (troco >= 100)
                {                   
                    troco -= 100;                    
                    t100++;                   
                }

                while (troco >= 50)
                {                   
                    troco -= 50;                    
                    t50++;                   
                }
                while (troco >= 10)
                {                   
                    troco -= 10;                    
                    t10++;                   
                }

                while (troco >= 5)
                {                   
                    troco -= 5;                   
                    t5++;
                }

                while (troco >=1)
                {                    
                    troco -= 1;                    
                    t1++;                   
                }
                
                while (troco >= 0.50)
                {                    
                    troco -= 0.50;                   
                    m5++;                   
                }
                
                while (troco >= 0.25)
                {                    
                    troco -= 0.25;                    
                    m25++;                    
                }
                
                while (troco >= 0.10)
                {                    
                    troco -= 0.10;                    
                    m10++;                   
                }

                while (troco >= 0.05)
                {
                    troco -= 0.05;
                    m05++;
                }

                while (troco >= 0.01)
                {
                    troco -= 0.01;
                    m1++;  
                }

                if (pago > produ) Console.WriteLine("Valor a ser pago: R$ {0}", produ);
                if (pago > produ) Console.WriteLine("Valor pago: R$ {0}", pago);
                if (pago > produ) Console.WriteLine("Valor do troco: R$ {0}", (pago-produ));
                if (t100 > 0) Console.WriteLine("{0} Nota(s) de: R$ 100,00 reais", t100);
                if (t50 > 0) Console.WriteLine("{0} Nota(s) de: R$ 50,00 reais", t50);
                if (t10 > 0) Console.WriteLine("{0} Nota(s) de: R$ 10,00 reais", t10);
                if (t5 > 0) Console.WriteLine("{0} Nota(s) de: R$ 5,00 reais", t5);
                if (t1 > 0) Console.WriteLine("{0} Moeda(s) de: R$ 1,00 real", t1);
                if (m5 > 0) Console.WriteLine("{0} Moeda(s) de: R$ 0,50 centavos", m5);
                if (m25 > 0) Console.WriteLine("{0} Moeda(s) de: R$ 0,25 centavos", m25);
                if (m10 > 0) Console.WriteLine("{0} Moeda(s) de: R$ 0,10 centavos", m10);
                if (m05 > 0) Console.WriteLine("{0} Moeda(s) de: R$ 0,05 centavos", m05);
                if (m1 > 0) Console.WriteLine("{0} Moeda(s) de: R$ 0,01 centavos", m1);

            }
            Console.ReadKey();
        }
    }
}
