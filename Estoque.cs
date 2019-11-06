using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Estoque{

  public List<Produto> prod = new List<Produto>();

  public void IncluirProduto(Produto produto ){
    prod.Add(produto);
  
  
  }


  public void MostrarProduto(){
    for(int i = 0 ; i < prod.Count ; i++){
      Console.WriteLine(prod[i].MostrarNaLista());
    }
  }
}