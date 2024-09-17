/*
    El patrón Proxy es un patrón de diseño estructural que proporciona un sustituto o un "representante" de otro objeto 
    para controlar el acceso a este. El objetivo principal del patrón Proxy es añadir una capa de control sobre el objeto original, 
    permitiendo controlar aspectos como el acceso, la carga diferida o la manipulación de funciones adicionales.
 */
using Proxy;

Console.Title = "Proxy Pattern";

IImage image = new ImageProxy("myimage.jpg");

// La imagen se carga desde el disco solo la primera vez que se llama a Display()
Console.WriteLine("First call to display: ");
image.Display();

Console.WriteLine("\nSecond call to display: ");
image.Display();


Console.ReadKey();
// Note: *Para verlo mas claro poner un breakpoint en la linea 50 en el file implementation*