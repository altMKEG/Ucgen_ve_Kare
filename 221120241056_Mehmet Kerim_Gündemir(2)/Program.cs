// See https://aka.ms/new-console-template for more information
Console.WriteLine("Çevre ve Alan hesaplama");

int side1;
int side2;
int side3;

Console.WriteLine("Üçgenin 1. kenarını giriniz");
side1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Üçgenin 2. kenarını giriniz");
side2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Üçgenin 3. kenarını giriniz");
side3 = Convert.ToInt16(Console.ReadLine());

int total = (side1 + side2 + side3);

Console.WriteLine($"Üçgenin çevresi = {total}");

int kenar1;

Console.WriteLine("Karenin alanı için kenar giriniz");
kenar1 = Convert.ToInt16(Console.ReadLine());

int product = (kenar1 * kenar1);
Console.WriteLine($"Karenin alanı = {product}");

Console.ReadLine();



