// See https://aka.ms/new-console-template for more information
double lado;
double superficie, perimetro;
Console.Write("Ingrese el valor del lado del cuadrado:");
lado= double.Parse(Console.ReadLine());
superficie = Math.Pow(lado, 2);//eleva al cuadrado el valor del lado
perimetro = lado * 4;
Console.WriteLine($"La superficie del cuadrado de lado {lado} es {superficie}");
//Console.WriteLine("La superficie del cuadrado es {0}",superficie); //forma anterior
Console.WriteLine($"El perímetro del cuadrado de lado {lado} es {perimetro}");
