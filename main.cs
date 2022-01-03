using System;

class Program {
  public static void Main (string[] args) {
    Setor s1 = new Setor(1, "Cavalos");
    Setor s2 = new Setor(2, "Porcos");
    Setor s3 = new Setor(3, "Bois");
    Console.WriteLine (s1);
    Console.WriteLine (s2);
    Console.WriteLine (s3);

    Tarefa t1 = new Tarefa (1, "Cuidar de Porcos", "Cuidar dos 150 porcos da fazenda", 5);
    Tarefa t2 = new Tarefa (2, "Banhar os cavalos", "Dar banhos no 50 cavalos da fazenda", -2);
    Tarefa t3 = new Tarefa (3, "Pastar os bois", "colocar as 345 cabeças de boi para o chiqueiro", 2);
    Console.WriteLine (t1);
    Console.WriteLine (t2);
    Console.WriteLine (t3);
  }
}

class Setor{
	private int id;
	private string descricao;
	public Setor(int id, string descricao){
		this.id = id;
		this.descricao = descricao;
	}

  public void SetId (int id){
	this.id = id;
  }
  public int GetId(){
	  return id;
  }
  public void SetDescricao (string descricao){
	  this.descricao = descricao;
  }
  public override string ToString(){
	return id + "-" + descricao;
  }
}

class Tarefa{
	private int id;
  private string titulo;
	private string descricao;
  private int qtd_func_nec;

	public Tarefa(int id, string titulo, string descricao, int qtd_func_nec){
		this.id = id; 
    this.titulo = titulo;
		this.descricao = descricao;
    this.qtd_func_nec = qtd_func_nec > 0 ? qtd_func_nec: 0;
   
	}

  public void SetId (int id){
	  this.id = id;
  }
  public void SetTitulo (string titulo){
	  this.id = id;
  }
  public void SetDescricao (string descricao){
  	this.descricao = descricao;
  }
  public void SetQtd_func_nec (int qtd_func_nec){
    this.qtd_func_nec = qtd_func_nec > 0 ? qtd_func_nec: 0;
  }
  public int GetId(){
	  return id;
  }
  public string GetTitulo(){
	  return titulo;
  }
  public int GetDescricao(){
	  return descricao;
  }

public override string ToString(){
	return id +" - "+ titulo +" - "+ descricao +" - "+ qtd_func_nec;
}
}

