using System;

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
   public string GetDescricao(){
	  return descricao;
  }
  public void SetDescricao (string descricao){
	  this.descricao = descricao;
  }
  public override string ToString(){
	return id + "-" + descricao;
  }
}