using System;

class Setor{
	private int id;
	private string descricao;
  private Tarefa[] tarefas = new Tarefa[10];
  private int nt;

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
  public void TarefaInserir(Tarefa t){
    if (nt == tarefas.Length){
	    Array.Resize(ref tarefas, 2 * tarefas.Length);
    }
	  tarefas[nt] = t;
	  nt++;
  }
  public Tarefa[] TarefaListar(){
	  Tarefa[] c = new Tarefa[nt];
    Array.Copy(tarefas, c, nt);
    return c;

  }
  public override string ToString(){
	return id + " - " + descricao +" - Nº tarefas " +nt;
  }
}