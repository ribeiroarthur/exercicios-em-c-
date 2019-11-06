

class Produto{

  Estoque  estoque = new Estoque();
 
  private  string data;
  private string marca;
  private  string tipo;

  public Produto(){
    data = "9999";
    marca = "999";
    tipo = "999";
  }
  
  public string getData(){
   return data;
  }
  
  public string getMarca(){
  return marca;
  }

  public string getTipo(){
   return tipo;
  }

  public void setData( string d ){
    data = d;
  }

  public void setMarca( string m){
    marca = m;
  }

  public void setTipo( string t){
    tipo = t;
  }

  public  Produto (string d, string m , string t){
    data = d;
    marca =m;
    tipo = t;

  } 


  
  public Produto  CriarProduto(string data, string marca,string tipo){
    Produto  produto = new Produto(data, marca , tipo);
    // estou retorna  ndo o produto  
    estoque.IncluirProduto(produto);
    return produto;
       
  }

   public void AssociarEstoque(Estoque est){
    estoque=est;
  }

  public string MostrarNaLista(){
    return string.Format("Data:{0} \n Marca:{1} \n Tipo: {2}\n================",data,marca,tipo);
  } 


  
}