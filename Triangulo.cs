using System;

class Triangulo{
  //atributos da minha class
  private double areaA;
  private double areaB;
  private double areaC;

  public Triangulo(){
    areaA = 000;
    areaB = 000;
    areaC = 000;


  }
  public Triangulo(double nA, double nB , double nC){
    areaA = nA ;
    areaB = nB ;
    areaC = nC ;
  }

  public double Area(){
    double p = (areaA + areaB + areaC )/2;
    return Math.Sqrt(p*(p-areaA)*(p-areaB)*(p-areaC));
  }

  public double AreaMaior(double areaX , double areaY){
    if( areaX > areaY)
      return areaX;
    else
      return areaY;
  }

  
}