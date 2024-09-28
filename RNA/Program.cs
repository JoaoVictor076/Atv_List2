
using RNA;

NeuRArtificial neuronioArtificial = new NeuRArtificial(0.5);

List<Entradas> entradas = new List<Entradas>
{
    new Entradas(113, 1.37, 1), // Maçã
    new Entradas(122, 4.7, 0), // Laranja
    new Entradas(107, 5.2, 1), // Maçã
    new Entradas(98, 3.6, 1),  // Maçã
    new Entradas(115, 2.9, 0), // Laranja
    new Entradas(120, 4.2, 0), // Laranja
    new Entradas(110, 6.5, 1), // Maçã
    new Entradas(125, 4.1, 0), // Laranja
    new Entradas(105, 6.0, 1), // Maçã
    new Entradas(130, 4.3, 0), // Laranja
    new Entradas(115, 6.2, 1), // Maçã
};


neuronioArtificial.Treinar(entradas, 3000);


Console.WriteLine("Pesos finais:");
Console.WriteLine("W1: " + neuronioArtificial.pesos.W1);
Console.WriteLine("W2: " + neuronioArtificial.pesos.W2);


Console.WriteLine("Classificação das entradas:");
foreach (var entrada in entradas)
{
    var resultado = neuronioArtificial.Perguntar(entrada.Entrada1, entrada.Entrada2);
    Console.WriteLine($"Entrada ({entrada.Entrada1}, {entrada.Entrada2}): " + (resultado == 1 ? "Maçã" : "Laranja"));
}