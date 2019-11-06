using System;

class MainClass {
  public static void Main (string[] args) {

  Estudante [] vect = new Estudante[10];

    Console.WriteLine ("Quantos quartos serão alugados ?");
    int quarto = int.Parse(Console.ReadLine());
    for ( int i = 0; i <quarto;i++){

      Console.Write("Nome ?");
      string nome = (Console.ReadLine());

      Console.Write("Email ?");
      string email = (Console.ReadLine());

      Console.Write("Quarto ?");
      int quarto_P = int.Parse(Console.ReadLine());
      vect[quarto_P] = new Estudante (nome,email);

    }

    for ( int i = 0; i <10;i++){
      if (vect[i]!=null){
         Console.WriteLine (i+":"+vect[i]);
      }
    }
  }
}