using System;

class Program {
  private static NSetor nsetor = new NSetor();
  public static void Main (string[] args) {
  int opc = 0;
  Console.WriteLine("----- ORGANIZADOR DE TAREFAS -----");
  do {
    try{
       opc = Menu();
    switch(opc){
      case 1: SetorListar(); break;
      case 2: SetorInserir(); break;
      }
    } catch (Exception erro){
      Console.WriteLine(erro.Message);
      opc = 100;

    }
   
  } while(opc != 0);

  Console.WriteLine("Aplicação finalizada :)");
  }

  public static int Menu(){
	  Console.WriteLine();
    Console.WriteLine("----------------------------------");
    Console.WriteLine("1 - Listar Setores");
    Console.WriteLine("2 - Inserir Setor");
    Console.WriteLine("0 - Finalizar");
    Console.WriteLine("Infrome uma opção:");
    int opc = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return opc;
}

  public static void SetorListar(){
    Console.WriteLine("----- TODOS OS SETORES -----");
    Setor[] setores = nsetor.Listar();
    if (setores.Length == 0){
	    Console.WriteLine("Nenhum setor cadastrado");
	    return;
    }
    foreach(Setor s in setores) Console.WriteLine(s);
      Console.WriteLine();
  }

  public static void SetorInserir(){
    Console.WriteLine("----- INSERIR SETOR -----");
    Console.Write("Código: " );
    int id = int.Parse(Console.ReadLine());
    Console.Write("Descrição: ");
    string descricao = Console.ReadLine();

    Setor s = new Setor(id, descricao);

    nsetor.Inserir(s);
    Console.WriteLine("Setor cadastrado com sucesso!");
}


}


