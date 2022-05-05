using PP4;

Circulo circulo1 = new Circulo(5.33,5,20);
Rectangulo rectangulo1 = new Rectangulo(10,5);

Console.WriteLine(circulo1);
Console.WriteLine("perimetro: "+circulo1.perimetro() + " area: " + circulo1.area());

Console.WriteLine(rectangulo1);
Console.WriteLine("perimetro: "+rectangulo1.perimetro() + " area:" + rectangulo1.area());