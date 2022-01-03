using System;

class Program {
  public static void Main (string[] args) {
    Setor s1 = new Setor(1, "Cavalos");
    Setor s2 = new Setor(2, "Porcos");
    Setor s3 = new Setor(3, "Bois");
    Console.WriteLine (s1);
    Console.WriteLine (s2);
    Console.WriteLine (s3);

    Tarefa t1 = new Tarefa (1, "Cuidar de Porcos", "Cuidar dos 150 porcos da fazenda", 5, s2);
    Tarefa t2 = new Tarefa (2, "Banhar os cavalos", "Dar banhos no 50 cavalos da fazenda", -2);
    Tarefa t3 = new Tarefa (3, "Pastar os bois", "colocar as 345 cabeças de boi para o chiqueiro", 2, s3);
    Console.WriteLine (t1);
    Console.WriteLine (t2);
    Console.WriteLine (t3);
  }
}


