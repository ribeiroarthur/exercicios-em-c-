using System;
using System.Collections.Generic;

class MainClass {
 
 

  public static void Main (string[] args) {

    Produto  produto= new Produto();

    Estoque estoque = new Estoque();
    produto.AssociarEstoque(estoque);
    
    string opcao="1";
    int n=0;

    Console.WriteLine ("digite a data do produto:");
    opcao = Console.ReadLine();
 
    while (opcao =="1"){

    Console.WriteLine ("digite a data do produto:");
    opcao = Console.ReadLine();
 
 
    if(opcao == "1"){


     Console.WriteLine ("digite a data do produto:");
     string data = Console.ReadLine();

     Console.WriteLine ("digite a marca do   produto:");
     string marca = Console.ReadLine();

     Console.WriteLine ("digite o tipo do produto:");
     string tipo  = Console.ReadLine();

      Produto listProduto = produto.CriarProduto(data,marca,tipo);

      produto.MostrarNaLista();
    }
    if(opcao == "2"){
      break;
    }
  
    }
  }
  
}
