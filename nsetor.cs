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
}