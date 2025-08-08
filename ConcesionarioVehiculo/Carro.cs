
namespace ConcesionarioVehiculo
{
    public class Carro : Vehiculo
    {
        public int NumeroPuertas { get; set; } 
        public string TipoCombustible { get; set; } 

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Número de Puertas: {NumeroPuertas}");
            Console.WriteLine($"Tipo de Combustible: {TipoCombustible}");
            Console.WriteLine();
        }
    }
}
