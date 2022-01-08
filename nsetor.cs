using System;

class NSetor{
	private Setor[] setores = new Setor[10];
	private int sc;

	public Setor[] Listar(){
	  Setor[] s = new Setor[sc];
	  Array.Copy(setores, s, sc);
	  return s;
  }
  public Setor Listar(int id){
    for (int i = 0; 1 < sc; i++){
      if (setores[i].GetId()== id) return setores[i];
    }
    return null;
	
  }
  public void Inserir(Setor s){
    if (sc == setores.Length){
		  Array.Resize(ref setores, 2 * setores.Length);
    }
	  setores[sc] = s;
	  sc++;
  } 
  public void Atualizar(Setor s){
    Setor s_atual = Listar(s.GetId());
    if (s_atual == null) return;

    s_atual.SetDescricao(s.GetDescricao());
  } 

  private int Indice(Setor s){
    for (int i = 0; i< sc; i++)
      if (setores[i] == s) return i;
  	return -1;
}
  public void Excluir(Setor s){
    int n = Indice(s);
    if (n == -1) return;
    for (int i = n; i < sc - 1; i++)
        setores[i] = setores[i+1];
        sc--;

    Tarefa[] ts = s.TarefaListar();
    foreach(Tarefa t in ts) t.SetSetor(null);

  } 
}