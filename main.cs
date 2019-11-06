using System;

class MainClass {
  public static void Main (string[] args) {
   

   
    Console.Write("Nome do produto:");
    string nome = Console.ReadLine();

    Console.Write("Preço do produto:");
    float preco = float.Parse(Console.ReadLine());

    Console.Write("Quantidade  do produto:");
    int quantidade = int.Parse(Console.ReadLine());

    Produto produto =  new Produto(nome, preco , quantidade);

    Console.WriteLine("Nome do produto: "+produto);
    
    Console.Write("Adiconar produto:");
    int qte_A=int.Parse(Console.ReadLine());

  
    produto.Adiconar_P(qte_A);
   

    Console.WriteLine("Dados atualizados: "+produto);


    Console.WriteLine("Remover produto:");
    int qte_R=int.Parse(Console.ReadLine());

    produto.Remover_P(qte_R);
    
    Console.Write("Dados atualizados: "+produto);


  }
}