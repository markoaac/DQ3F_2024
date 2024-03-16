// See https://aka.ms/new-console-template for more information
using Unidad_II_dll;
using System.Threading;


Hilos hilo = new Hilos();

Thread proceso =
    new Thread(hilo.ImprimeY);
proceso.Start();

hilo.ImprimeX();


