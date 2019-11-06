using System;

class MainClass {
  public static void Main (string[] args) {


    Console.WriteLine ("Entre com as informações do triâgulo x :");
    
    double triangulo1a=double.Parse(Console.ReadLine());
    double triangulo1b=double.Parse(Console.ReadLine());
    double triangulo1c=double.Parse(Console.ReadLine());

    Triangulo triangulo1 = new Triangulo (triangulo1a,triangulo1b,triangulo1c);

    Console.WriteLine ("Entre com as informações do triâgulo y:");

    double triangulo2a=double.Parse(Console.ReadLine());
    double triangulo2b=double.Parse(Console.ReadLine());
    double triangulo2c=double.Parse(Console.ReadLine());

    Triangulo triangulo2 = new Triangulo (triangulo2a,triangulo2b,triangulo2c);

    double areaX = triangulo1.Area();

    double areaY = triangulo2.Area();


    Console.WriteLine ("Área do Triângulo X é de {0}",areaX);

    Console.WriteLine ("Área do Triângulo yé de {0}",areaY);

  
    Console.WriteLine(triangulo1.AreaMaior(areaX,areaY));




    /*

    if (areaX>areaY){
      Console.WriteLine ("Maior foi a área X");
      
    }else if (areaX==areaY){
      Console.WriteLine ("Mesmo tamanho");
    }else if (areaY>areaX){
      Console.WriteLine ("Maior foi a área Y");
    }

    */

  }
}