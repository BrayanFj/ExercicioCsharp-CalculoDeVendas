using System;

class Program {
  public static void Main (string[] args) {

    Console.Write("Insira o numero de vendas do funcionario 1: ");
    double Vendas1 = int.Parse(Console.ReadLine());

    Console.Write("Insira o numero de vendas do funcionario 2: ");
    double Vendas2 = int.Parse(Console.ReadLine());

    Console.Write("Insira o numero de vendas do funcionario 3: ");
    double Vendas3 = int.Parse(Console.ReadLine());

    int metaVendas = 1000;

    if (Vendas1 >= 2000){
       Vendas1  = Vendas1 * 0.15;

      Console.WriteLine("Funcionario 1 superou a meta de vendas e ganhou 15% de bonus, seu pagamento foi:" + Vendas1);
    } else if (Vendas1 > 1000 && Vendas1 < 1999) {

       Vendas1  = Vendas1 * 0.10;
      
      Console.WriteLine("Funcionario 1 atingiu a meta de vendas e ganhou 10% de bonus, seu pagamento foi:" + Vendas1);

    } else {
      Console.WriteLine(" Funcionario 1 Não atingiu a meta de vendas");

    }



    if (Vendas2 >= 2000){
       Vendas2  = Vendas2 * 0.15;

      Console.WriteLine("Funcionario 2 superou a meta de vendas e ganhou 15% de bonus, seu pagamento foi:" + Vendas2);
    } else if (Vendas2 > 1000 && Vendas2 < 1999) {

       Vendas2  = Vendas2 * 0.10;

      Console.WriteLine("Funcionario 2 atingiu a meta de vendas e ganhou 10% de bonus, seu pagamento foi:" + Vendas2);

    } else {
      Console.WriteLine(" Funcionario 2 Não atingiu a meta de vendas");

    }


    if (Vendas3 >= 2000){
       Vendas3  = Vendas3 * 0.15;

      Console.WriteLine("Funcionario 3 superou a meta de vendas e ganhou 15% de bonus, seu pagamento foi:" + Vendas3);
    } else if (Vendas3 > 1000 && Vendas3 < 1999) {

       Vendas3  = Vendas3 * 0.10;

      Console.WriteLine("Funcionario 3 atingiu a meta de vendas e ganhou 10% de bonus, seu pagamento foi:" + Vendas3);

    } else {
      Console.WriteLine(" Funcionario 3 Não atingiu a meta de vendas");

    }
   
  }
}