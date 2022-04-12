//17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse 80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.

Console.WriteLine("Limite de velocidade da via é de 80Km/h \nQual a velocidade que o condutor do veículo passou pelo radar?");
double velocity = double.Parse(Console.ReadLine());

if (velocity > 80.00)
{
    Console.WriteLine("O condutor foi multado");
    decimal trafficTicket = (decimal)((velocity - 80) * 5);
    Console.WriteLine($"Para cada Km acima da velocidade será cobrado R$5,00. \nValor total da multa: R${trafficTicket}");
}
else
    Console.WriteLine("O condutor não foi multado");