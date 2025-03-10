//casteos

//* Conversion implicita
int numeroEntero = 42;
double numeroDouble = numeroEntero;

//si cabe porque es mas grande

Console.WriteLine(numeroEntero);
Console.WriteLine(numeroDouble);

//Conversion explicita
double numeroDecimal = 42.96;
int numeroEntero2 = (int)numeroDecimal;

Console.WriteLine(numeroDecimal);
Console.WriteLine(numeroEntero2);
//perdida de informacion corta lo que no cabe

//Convert

string numeroTexto = "23";
string sumaTexto = "1" + numeroTexto;
int numero = Convert.ToInt32(numeroTexto);
Console.WriteLine(numero+1);
//no es tipo de dato primitivo

//PArse solo se utiliza para strings

string texto = "3.1416";

    double pi = double.Parse(texto);
Console.WriteLine(pi);
Console.WriteLine(pi*2);
//Parse evita excepint.ciones
int piEntero;
bool exito = int.TryParse(texto, out 
    )
bool exito = int. TryParse(numeroTexto,
int piEntero = int.TryParse(texto, out piEntero);
Console.WriteLine(piEntero);

//Casteo de objetos

//DownC 