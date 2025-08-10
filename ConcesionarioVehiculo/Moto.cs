
namespace ConcesionarioVehiculo
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }
        public bool TieneMaletero { get; set; }

        public Moto(){ }
        public Moto(string marca, string modelo, int año, int cilindrada, bool tieneMaletero) : base(marca, modelo, año)
        {
            Cilindrada = cilindrada;
            TieneMaletero = tieneMaletero;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Cilindrada: {Cilindrada} cc");
            
            if (TieneMaletero)
            {
                Console.WriteLine("Tiene maletero: Si");
            }
            else
            {
                Console.WriteLine("No tiene maletero: No");
            }
            Console.WriteLine();
        }

    }
}
