class Produto{
 // aqui são os atributos 
  private string nome;
  private  float preco;
  private  int quantidade;

  public Produto(){
    nome = "000";
    preco = 00;
    quantidade = 000;
  }

  public Produto(string n, float p, int qtd){
    nome = n;
    preco  = p; 
    quantidade = qtd;
  }

  public string getNome(){
    return nome; 
  }

  public float getPreco(){
    return preco; 
  }

  public int getQuantidade(){
    return quantidade; 
  }

   public void setNome(string n){
    nome = n;
  }

  public void setPreco(float p){
    preco = p;    
  }

  public void setTamanho( int q){
    quantidade = q;
  }
  


  public double ValorTotalEstoque(){
    return preco*quantidade;

  }
  
  public void Adiconar_P(int quantidade_A){
    quantidade+=quantidade_A;
  }

  
  public void Remover_P(int quantidade_R){
    quantidade-=quantidade_R;
  }
  
  public override string ToString(){
    return nome + ", $R" + preco + ", quantidade: "+quantidade +","+
    " valor de estoque: $R "+ValorTotalEstoque();

  }
}