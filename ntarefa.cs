using System;

class NTarefa{
	private Tarefa[] tarefas = new Tarefa[10];
	private int tc;

	public Tarefa[] Listar(){
	  Tarefa[] t = new Tarefa[tc];
	  Array.Copy(tarefas, t, tc);
	  return t;
  }
  public Tarefa Listar(int id){
    for (int i = 0; 1 < tc; i++){
      if (tarefas[i].GetId()== id) return tarefas[i];
    }
    return null;
	
  }
  public void Inserir(Tarefa t){
    if (tc == tarefas.Length){
		  Array.Resize(ref tarefas, 2 * tarefas.Length);
    }
	  tarefas[tc] = t;
	  tc++;
    Setor s = t.GetSetor();
    if (s != null) s.TarefaInserir(t);
  } 
}