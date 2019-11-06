class Salario{

  
  private  string nome;
  private  float salario;


  public Salario(){
    nome = "Sem nome ainda!";
    salario = 00;
  }
  public Salario(string n, float s){
    nome = n;
    salario = s;
  }


  public string getNome(){
    return nome;
  }

  public float getSalario(){
    return salario;
  }

  public void setNome(string n ){
    nome = n;
  }

  public void  setSalario(float s){
    salario = s;
  }

   public float  Somar(){
     return salario;
  }

}