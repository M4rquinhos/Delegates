
using Delegates;

var objeto = new ClassFuncion();

MiDelegate f = objeto.func1;
Console.WriteLine($"El resultado es: {f(3, 4)}");

f = objeto.func2;
Console.WriteLine($"El resultado es: {f(3, 4)}");

Console.WriteLine($"");
public delegate string MiDelegate(int arg1, int arg2);

