using System;

namespace Cadastro_Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nome = new string[10];
            float[] preco = new float[10];
            int num;   
            int t=0;    

             Console.ForegroundColor = ConsoleColor.Cyan;

            while(t==0){
             //Menu
             Console.WriteLine("O que você deseja fazer?");
             Console.WriteLine("[1] - Cadastrar novo produto");
             Console.WriteLine("[2] - Listar Produtos");
             Console.WriteLine("[3] - Verificar promoção]");   
             num = int.Parse(Console.ReadLine());
      
        if(num == 1){
           
            Console.WriteLine("Deseja cadastrar um novo produto?");
            string resposta = Console.ReadLine();
           

            while( resposta == "sim"){
            var i=0;
            
            Console.WriteLine("Digite um produto e seu preço");
            nome[i] = Console.ReadLine();

            preco[i] = float.Parse(Console.ReadLine());

            i = i++;
            Console.WriteLine("Deseja cadastrar um novo produto?");
            resposta = Console.ReadLine();
            
            }
            Console.WriteLine("O que você deseja fazer?");
             Console.WriteLine("[1] - Cadastrar novo produto");
             Console.WriteLine("[2] - Listar Produtos");
             Console.WriteLine("[3] - Verificar promoção]");   
             num = int.Parse(Console.ReadLine());

               }else if( num == 2){
            Console.WriteLine("Listando Produtos:");
            for(var i=0;i<10;i++){
            Console.WriteLine(nome[i]+"-Preço: R$ "+preco[i]);
            
            }
            Console.WriteLine("O que você deseja fazer?");
             Console.WriteLine("[1] - Cadastrar novo produto");
             Console.WriteLine("[2] - Listar Produtos");
             Console.WriteLine("[3] - Verificar promoção]");   
             num = int.Parse(Console.ReadLine());

        }else if(num == 3){
            
            Console.WriteLine("Verificando promoção");
            Console.WriteLine("Escolha o número referente ao produto desejado:");

            Console.WriteLine("[0] -" +nome[0]);
               Console.WriteLine("[1]-"+nome[1]);
                  Console.WriteLine("[2]-"+nome[2]);
                     Console.WriteLine("[3]-"+nome[3]);
                        Console.WriteLine("[4]-"+nome[4]);
                           Console.WriteLine("[5]-"+nome[5]);
                              Console.WriteLine("[6]-"+nome[6]);
                                 Console.WriteLine("[7]-"+nome[7]);
                                    Console.WriteLine("[8]-"+nome[8]);
                                       Console.WriteLine("[9]-"+nome[9]);
            int escolha = int.Parse(Console.ReadLine());

            Promocao(preco);
        
           
            bool Promocao(float[] preco){
                var i = escolha;
                if(preco[i] < 50){
                    Console.WriteLine("Está em promoção!");
                    return true;
                }else{
                    Console.WriteLine("Não está em promoção");
                    return false;
                }
            }
        
                       
            }else{
            Console.WriteLine("O que você deseja fazer?");
             Console.WriteLine("[1] - Cadastrar novo produto");
             Console.WriteLine("[2] - Listar Produtos");
             Console.WriteLine("[3] - Verificar promoção]");   
             num = int.Parse(Console.ReadLine());

        }
            }
            }
        }
    }
    




     
