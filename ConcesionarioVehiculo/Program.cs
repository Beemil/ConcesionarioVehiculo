using ConcesionarioVehiculo;


Carro carro1 = new Carro();
carro1.Marca = "Suzuki";
carro1.Modelo = "Jimny";
carro1.Año = 2024;
carro1.NumeroPuertas = 3;
carro1.TipoCombustible = "Gasolina";
carro1.MostrarInformacion();

Carro carro2 = new Carro();
carro2.Marca = "Toyota";
carro2.Modelo = "Corolla";
carro2.Año = 2006;
carro2.NumeroPuertas = 4;
carro2.TipoCombustible = "Gasolina";
carro2.MostrarInformacion();

Moto moto1 = new Moto();
moto1.Marca = "Genesis";
moto1.Modelo = "Klik 150";
moto1.Año = 2025;
moto1.Cilindrada = 150;
moto1.TieneMaletero = true;
moto1.MostrarInformacion();

Moto moto2 = new Moto();
moto2.Marca = "Yamaha";
moto2.Modelo = "MT-07";
moto2.Año = 2023;
moto2.Cilindrada = 689;
moto2.TieneMaletero = false;
moto2.MostrarInformacion();



