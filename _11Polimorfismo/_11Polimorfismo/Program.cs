using _11Polimorfismo;

Imposto objetoE = new Estagiario();
objetoE.valeAlimentacao(1000);
objetoE.valeTransporte(1000);
Console.WriteLine("-----------------------------------------------------");

Imposto objetoG = new Gerente();
objetoG.valeAlimentacao(1000);
objetoG.valeTransporte(1000);
Console.WriteLine("-----------------------------------------------------");

Imposto objetoA = new Atendente();
objetoA.valeAlimentacao(2000);
objetoA.valeTransporte(2000);
Console.WriteLine("-----------------------------------------------------");


