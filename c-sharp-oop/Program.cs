using c_sharp_oop.Classes;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

Car honda = new Car("Honda", 2019, 120);

honda.Color = "Negro";
honda.Owner = "ralfxdev";
honda.Price = "$1,000,000.00";
honda.Plate = "A123456";

Console.WriteLine("Datos del Carro\n");
Console.WriteLine($"Marca: {honda.Brand}");
Console.WriteLine($"Modelo: {honda.Model}");
Console.WriteLine($"Velocidad Máxima: {honda.MaxSpeed}km/h");
Console.WriteLine($"Color: {honda.Color}");
Console.WriteLine($"Dueño: {honda.Owner}");
Console.WriteLine($"Precio: {honda.Price}");
Console.WriteLine($"Placa: {honda.Plate}\n");

honda.SwitchCar();

if (honda.IsOn)
{
    Console.WriteLine("Simulador de Viaje\n");

    if (honda.IsLookDoors)
    {
        Console.WriteLine("Las puertas están abiertas\n");
    } else
    {
        Console.WriteLine("Las puertas están cerradas\n");
    }

    honda.SwitchLights();
    if (honda.IsLightsOn)
    {
        Console.WriteLine("Las luces están encendidas\n");
    } else
    {
        Console.WriteLine("Las luces están apagadas\n");
    }

    honda.Refuel(100);

    if (honda.GetFuelLevel() > 0)
    {
        Console.WriteLine($"El tanque tiene -> {honda.GetFuelLevel()}lts\n");
    } else
    {
        Console.WriteLine("El tanque no está lleno\n");
    }

    Console.WriteLine("El carro está encendido\n");
    honda.Clutch();
    Console.WriteLine($"Subiste un cambio -> {honda.ShiftUp()}\n");
    honda.Clutch();
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h");
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Subiste un cambio -> {honda.ShiftUp()}\n");
    honda.Clutch();
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h\n");
    Console.WriteLine($"Frenaste -> {honda.Brake()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Bajaste un cambio -> {honda.ShiftDown()}\n");
    honda.Clutch();
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h");
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h");
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Subiste un cambio -> {honda.ShiftUp()}\n");
    honda.Clutch();
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h");
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h");
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Subiste un cambio -> {honda.ShiftUp()}\n");
    honda.Clutch();
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h");
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h");
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Subiste un cambio -> {honda.ShiftUp()}\n");
    honda.Clutch();
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h");
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Subiste un cambio -> {honda.ShiftUp()}\n");
    honda.Clutch();
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h");
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h");
    Console.WriteLine($"Aceleraste -> {honda.Accelerate()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Bajaste un cambio -> {honda.ShiftDown()}\n");
    honda.Clutch();
    Console.WriteLine($"Desaceleraste -> {honda.Decelerate()} km/h");
    Console.WriteLine($"Desaceleraste -> {honda.Decelerate()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Bajaste un cambio -> {honda.ShiftDown()}\n");
    honda.Clutch();
    Console.WriteLine($"Desaceleraste -> {honda.Decelerate()} km/h");
    Console.WriteLine($"Desaceleraste -> {honda.Decelerate()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Bajaste un cambio -> {honda.ShiftDown()}\n");
    honda.Clutch();
    Console.WriteLine($"Desaceleraste -> {honda.Decelerate()} km/h");
    Console.WriteLine($"Desaceleraste -> {honda.Decelerate()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Bajaste un cambio -> {honda.ShiftDown()}\n");
    honda.Clutch();
    Console.WriteLine($"Desaceleraste -> {honda.Decelerate()} km/h");
    Console.WriteLine($"Desaceleraste -> {honda.Decelerate()} km/h\n");
    Console.WriteLine($"Frenaste -> {honda.Brake()} km/h\n");
    honda.Clutch();
    Console.WriteLine($"Bajaste un cambio -> {honda.ShiftDown()}\n");
    honda.Clutch();

    honda.SwitchCar();
    Console.WriteLine($"Tu tanque tiene -> {honda.GetFuelLevel()}lts");
} else
{
    Console.WriteLine("El carro está apagado");
}