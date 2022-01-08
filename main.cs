using System;

class Program {
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
    Console.WriteLine("---------------------");
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
}

  public static void SetorInserir(){
    Console.WriteLine("----- INSERIR SETOR -----");

}


}


