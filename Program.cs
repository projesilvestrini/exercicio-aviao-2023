namespace exercicio_aviao_2023;
class Program
{
    static void Main(string[] args)
    {
      //  Console.WriteLine("Hello");
        //Console.ReadKey();

        //instanciar um objeto apartir da class
        Exemplo exe01 = new Exemplo();
        exe01.mostraMsg();

        exe01.mostraNome("andre");

        Console.WriteLine(exe01.mns());

        Console.WriteLine();
        System.Console.WriteLine("a soma é: "+ exe01.somar(1,1));

    }
}
