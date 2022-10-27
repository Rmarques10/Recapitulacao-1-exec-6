/* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
mostre: 
a) a área do triângulo retângulo que tem A por base e C por altura. 
b) a área do círculo de raio C. (pi = 3.14159) 
c) a área do trapézio que tem A e B por bases e C por altura. 
d) a área do quadrado que tem lado B. 
e) a área do retângulo que tem lados A e B */

using System.Globalization;

double a, b, c, pi = 3.14159, triangulo, circulo, trapezio, quadrado, retangulo;

Console.WriteLine("Informe o valor de A , B e C:");
string[] valores = Console.ReadLine().Split(' ');
a = double.Parse(valores[0], CultureInfo.InvariantCulture);
b = double.Parse(valores[1], CultureInfo.InvariantCulture);
c = double.Parse(valores[2], CultureInfo.InvariantCulture);


triangulo = a * c / 2.0;
circulo = 3.14159 * c * c;
trapezio = (a + b) / 2.0 * c;
quadrado = b * b;
retangulo = a * b;

Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));