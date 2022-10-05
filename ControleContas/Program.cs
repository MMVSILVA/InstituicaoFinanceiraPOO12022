// See https://aka.ms/new-console-template for more information
using ControleContas.Model;

Conta conta1 = new Conta(987654321);
Conta conta2 = new Conta(123456789);
Conta conta3 = new Conta(654321);

conta1.Deposito(1000);
conta2.Deposito(1000);
conta3.Deposito(234142);

Console.WriteLine($"Número da conta 1 : {conta1.Numero}. ");
Console.WriteLine($"Número da conta 2 : {conta2.Numero}. ");
Console.WriteLine($"Número da conta 3 : {conta3.Numero}. ");

Console.WriteLine($"A conta: c/c {conta1.Numero} está com o saldo de R$ {conta1.ToString()}. ");

if (conta1.Saque(100))
{
    Console.WriteLine($"Saque efetuado com sucesso!!.");
    Console.WriteLine($"Conta {conta1.Numero}, saldo {conta1.ToString()}");

}
else
{
    Console.WriteLine($"O valor do saque é maior que o saldo");
}

if (conta1.Transferencia(500, conta2))

    Console.WriteLine($"Transferência efetuado com sucesso!!.");
{
    Console.WriteLine(conta1.ToString());
    Console.WriteLine(conta2.ToString());

}
