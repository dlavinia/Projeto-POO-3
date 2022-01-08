using System;

class Program {
  private static NSetor nsetor = new NSetor();
  private static NTarefa ntarefa = new NTarefa();
  public static void Main (string[] args) {
  int opc = 0;
  Console.WriteLine("----- ORGANIZADOR DE TAREFAS -----");
  do {
    try{
       opc = Menu();
    switch(opc){
      case 1: SetorListar(); break;
      case 2: SetorInserir(); break;
      case 3: TarefaListar(); break;
      case 4: TarefaInserir(); break;
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
    Console.WriteLine("3 - Listar Tarefas");
    Console.WriteLine("4 - Inserir Tarefa");
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

  public static void TarefaListar(){
    Console.WriteLine("----- TODAS AS TAREFAS  -----");
    Tarefa[] tarefas = ntarefa.Listar();
    if (tarefas.Length == 0){
	    Console.WriteLine("Nenhuma tarefa cadastrada");
	    return;
    }
    foreach(Tarefa t in tarefas) Console.WriteLine(t);
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

  public static void TarefaInserir(){
    Console.WriteLine("----- INSERIR TAREFA -----");
    Console.Write("Código: " );
    int id = int.Parse(Console.ReadLine());
    Console.Write("Titulo: ");
    string titulo = Console.ReadLine();
    Console.Write("Descrição: ");
    string descricao = Console.ReadLine();
     Console.Write("Nº de funcionarios necessarios para essa tarefa: " );
    int func_nec = int.Parse(Console.ReadLine());

    SetorListar();
    Console.Write("Informe o código do setor da Tarefa: ");
    int setorId = int.Parse(Console.ReadLine());

    Setor s = nsetor.Listar(setorId);

    Tarefa t = new Tarefa(id, titulo, descricao, func_nec, s);
    ntarefa.Inserir(t);

    Console.WriteLine("Tarefa cadastrada com sucesso!");
}


}


