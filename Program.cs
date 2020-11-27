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
    




     
