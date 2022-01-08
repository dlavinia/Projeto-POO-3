using System;

class Tarefa{
	private int id;
  private string titulo;
	private string descricao;
  private int qtd_func_nec;
  private Setor setor;

	public Tarefa(int id, string titulo, string descricao, int qtd_func_nec){
		this.id = id; 
    this.titulo = titulo;
		this.descricao = descricao;
    this.qtd_func_nec = qtd_func_nec > 0 ? qtd_func_nec: 0;
   
	}
  	public Tarefa(int id, string titulo, string descricao, int qtd_func_nec, Setor setor){
		this.id = id; 
    this.titulo = titulo;
		this.descricao = descricao;
    this.qtd_func_nec = qtd_func_nec > 0 ? qtd_func_nec: 0;
    this.setor = setor;
	}
  public void SetId (int id){
	  this.id = id;
  }
  public void SetTitulo (string titulo){
	  this.titulo = titulo;
  }
  public void SetDescricao (string descricao){
  	this.descricao = descricao;
  }
  public void SetQtd_func_nec (int qtd_func_nec){
    this.qtd_func_nec = qtd_func_nec > 0 ? qtd_func_nec: 0;
  }
  public void SetSetor(Setor setor){
    this.setor = setor;
  }
  public int GetId(){
	  return id;
  }
  public string GetTitulo(){
	  return titulo;
  }
  public string GetDescricao(){
	  return descricao;
  }
  public int GetQtd_func_nec(){
    return qtd_func_nec;
  }
  public Setor GetSetor(){
     return setor;
  }
public override string ToString(){
  if (this.setor == null){
	return id +" - "+ titulo +" - "+ descricao +" - "+ qtd_func_nec;
  } else {
    	return id +" - "+ titulo +" - "+ descricao +" - "+ qtd_func_nec + " - " + setor.GetDescricao();
  }
}
}