using System;

class MainClass {
  public static void Main (string[] args) {
  
  

    Console.WriteLine ("Diga o nome do primeiro funcionario:");
    string nome1=Console.ReadLine();

    Console.WriteLine ("Diga o salario do primeiro funcionario:");
    float salario1 = float.Parse(Console.ReadLine());

    Salario p1 = new Salario (nome1 , salario1);

    Console.WriteLine("Diga o nome do segundo funcionario:");
    string nome2=Console.ReadLine();

    Console.WriteLine ("Diga o salario do segundo funcionario:");
    float salario2=float.Parse(Console.ReadLine());

    Salario p2 = new Salario(nome2,salario2);

    Console.WriteLine("O salario: {0} ",(p1.Somar()+p2.Somar())/2);
    
    






  }
}