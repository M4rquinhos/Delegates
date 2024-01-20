
using Delegates;

var objeto = new ClassFuncion();

MiDelegate f = objeto.func1;
Console.WriteLine($"El resultado es: {f(3, 4)}");

f = objeto.func2;
Console.WriteLine($"El resultado es: {f(3, 4)}");

Console.WriteLine($"");
var objeto2 = new MiClase();
f = objeto2.InstanciaDeMetodo;
Console.WriteLine($"El resultado de la formula es: {f(56, 78)}");


Console.WriteLine($"///////////DELEGADOS ANONIMOS////////////////////////");

MiDelegate2 f2 = delegate (int i, string s)
{
    return i + 100;
};

int resultado = f2(250, "hola");


Console.WriteLine($"/////////////////////DELEGADOS COMPUESTOS///////////////////////////////");
static void func1(int arg1, int arg2)
{
    string resultado = (arg1 + arg2).ToString();
    Console.WriteLine(resultado);
};

static void func2(int arg1, int arg2)
{
    string resultado = (arg1 * arg2).ToString();
    Console.WriteLine(resultado);
};


MiDelegateCompuesto f3 = func1;
MiDelegateCompuesto f4 = func2;

MiDelegateCompuesto f3f4 = f3 + f4;
int arg1 = 10;
int arg2 = 30;
Console.WriteLine($"Se esta ejecutado el primer delegate ");
f3(arg1, arg2);
Console.WriteLine($"Se esta ejecutando el segundo delegate");
f4(arg1, arg2);
Console.WriteLine($"Se estan ejecutando el primer y el segundo delegate al mismo tiempo");
f3f4(arg1, arg2);

public delegate string MiDelegate(int arg1, int arg2);

public delegate int MiDelegate2(int i, string s);

public delegate void MiDelegateCompuesto(int arg1, int arg2);


