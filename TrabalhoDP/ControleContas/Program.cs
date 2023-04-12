using ControleContas.Model;

try
{

    Cliente mateus = new Cliente("Mateus", "25764508620", 2002);
    Banco itau = new Banco("Itau Unibanco", 015);
    Agencia BNB = new Agencia("25058327", 1205, itau);
    Conta itauMT = new Conta(123456789, BNB, mateus, 500);

    Cliente lucas = new Cliente("Lucas", "88396143282", 2004);
    Banco bradesco = new Banco("Banco Bradesco", 016);
    Agencia CNB = new Agencia("26487236", 1206, bradesco);
    Conta bradescoLC = new Conta(987654321, CNB, lucas, 3250);

    Cliente franco = new Cliente("Franco", "64237710955", 2000);
    Banco bancoBMG = new Banco("Banco BMG S.A", 017);
    Agencia DNB = new Agencia("01255389", 1207, bancoBMG);
    Conta bmgFC = new Conta(987654321, DNB, franco, 1200);

    itauMT.Deposito(3000);

    Console.WriteLine($"{itauMT.ToString()}");
    Console.WriteLine($"{bradescoLC.ToString()}");
    Console.WriteLine($"{bmgFC.ToString()}");

    Console.WriteLine("Juntando todas as contas temos o valor total de saldo de: " + (itauMT.Saldo + bradescoLC.Saldo + bmgFC.Saldo));

    Console.WriteLine($"A conta que possui o maior saldo é: {Conta._contaMaiorSaldo} tendo o saldo de: {Conta._maiorSaldo}");

}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}