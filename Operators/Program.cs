Console.WriteLine("Operadores de Atribuição");

int a = 10;
int b = 20;
int c = a + b;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);


//-----------------------------------
Console.Write('\n');
Console.WriteLine("Combinando Operadores");

Console.WriteLine(a);
a += 5;
Console.WriteLine(a);
a -= 5;
Console.WriteLine(a);
a *= 5;
Console.WriteLine(a);
a /= 5;
Console.WriteLine(a);

//-----------------------------------
Console.Write('\n');
Console.WriteLine("Convertendo tipos de variáveis");

int isNumber = Convert.ToInt32("2");
Console.WriteLine(isNumber);

int isANumber = int.Parse("3");
Console.WriteLine(isANumber);

//-----------------------------------
Console.Write('\n');
Console.WriteLine("Diferença entre Parse e Convert");

// int parseException = int.Parse(null);
// Console.WriteLine(parseException);

int convertException = Convert.ToInt32(null);
Console.WriteLine(convertException);

//-----------------------------------
Console.Write('\n');
Console.WriteLine("Conversão para String");

int isString = 5;
isString.ToString();
Console.WriteLine(isString);