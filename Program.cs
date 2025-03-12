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
                           //clase base
class Animal
{
    //Metodos 
    public void Respirar()
    {
        Console.WriteLine("EStoy respirando");
    }

    public virtual  void HacerSonido()
    {
        Console.WriteLine("Haace sonido");
    }
    interface IAnimalTerreste
        //lña interfaz solo va decrar
        //no va estar impementado
    {
        public void Caminar()
        {
           
        }
        //Metodo terrestre
        

    }
    interface IAnimalMAnufero
    {
        public void mamifero()
        {
           // Console.WriteLine("Haace cosas de mamifero");
        }
        
    }
}

class Perro : Animal , IAnimalTerreste , IAnimalMAnufero
{
    //Metod del perro
    public  override void HacerSonido()
    {
        Console.WriteLine("Gua Guau");
    }
    public void Caminar()
    {
        Console.WriteLine("puede caminar");
    }
}

class Gato : Animal
{
    //Metod del perro
    public override void HacerSonido()
    {
        Console.WriteLine("Miau Miau");
    }
}
public class Ejemplo : IEjemplo
{
    //implementacion del metodo de la interfaz

    public void HacerAlgo()
    {
        Console.WriteLine("Hacer algo");
    }
  
}
IEjemplo algo = new Ejemplo();
algo.HacerAlgo();
algo.HacerAlgoMas();
Perro miPerro = new Perro();

miPerro.Respirar();
miPerro.HacerSonido();

Animal pajaro = new Pajaro();
pajaro.V();
pajaro.Respirar();

Animal miAnimal = new Animal();
                           public interface IEjemplo
{
    //metodos de ejemplo
    void HacerAlgo()
    {
    }
    //metodo con implementacio perdeterminada
    public void HacerAlgoMas()
    {
        Console.WriteLine("Haciendo otra cosa");
    }
}
//interfaz es una opcipon para hacer apartados un cacho de informacion
//interface IVolador
{
    //Metodo Interfaz
    public void Volar()
    {
        
    }

}

class Pajaro : Animal , IVolador
{
    public void Volar()
    {
        Console.WriteLine("Estoy volando");
    }
    public override void HacerSonido()
    {
        Console.Write("pio pio");
    }

}
interface IPago
{
    //Metodo Interfaz
    public void ProcesarPago()
    {

    }

}



class PagoEfectivo : IPago
{
    //propiedades
    
    public double Monto { get; set; }

    //constructor
    // vas a recibir un parametro dentro de tu propiedad
    public  PagoEfectivo( double monto)
    {
        Monto = monto;
    }
    //Mentodo de pago Interfaz
    public void ProcesarPago()
    {
        Console.WriteLine($"Pago en efectivo {Monto} fue procesado");
    }

}

class PagoTarjeta : IPago
{
    //propiedades

    public double Monto { get; set; }
    //no podemos cambiar el numero de la tarjeta
    public string NumeroTarjeta { get; }
    //constructor
    // vas a recibir un parametro dentro de tu propiedad
    public PagoTarjeta(double monto, string numeroTarjeta)
    {
        Monto = monto;
        NumeroTarjeta = numeroTarjeta;
    }
    //Mentodo de pago Interfaz
    //igual al nombre de la interfaz
    public void ProcesarPago()
    {

        if (NumeroTarjeta.Length == 16)
        {
            Console.WriteLine($"Pago en tarjeta {Monto} fue procesado");
        }
        else
        {
            Console.WriteLine("Tarjeta invalida");
        }
    }
}


/* /casteos

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
/*
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
*
//Casteo de objetos

//DownC 

//conversiones por tipos de referencia

object obj = "Hola mundo";
string texto2 = obj as string;

Console.WriteLine(texto2);

*/ 
//lista de pagos a procesar

List <IPago>  listaPagos = new List <IPago> ();
//do
//{
    Console.WriteLine("Ingresa ek monto a pagar");
    string montoTexto = Console.ReadLine() ?? "";

    //convertir string  a double
    double montoNumero;
    if (double.TryParse(montoTexto, out montoNumero))
    {
        Console.WriteLine("¿Es un pafo con tarjeta y/n");
        string opcion = Console.ReadLine() ?? "";

        if (opcion == "y")
        {
            Console.WriteLine("Ingresa el numero de tarjeta");

            string tarjeta = Console.ReadLine() ?? "";

            //Crear el objeto pagotarqjeta
            IPago pago = new PagoTarjeta(montoNumero, tarjeta);

            listaPagos.Add(pago);
        }

        else
        {
            //objeto pado en efectivo
            IPago pago = new PagoEfectivo(montoNumero);

            listaPagos.Add(pago);

        }
    }
    else
    {
        Console.WriteLine("Monto invalido, ocurrio un error");
        return;
    }
    Console.WriteLine("¿Es un pafo con tarjeta y/n");
   // string op = Console.ReadLine() ?? "";
//} while(op == "r");

//do
Console.WriteLine("Procesando ....");
//Recorrer la lista de pagos
foreach (IPago pago in listaPagos)
{
    //Casteo con AS
    PagoTarjeta pagoTarjeta = pago as PagoTarjeta;
    
    if (pagoTarjeta != null)
    {
        Console.WriteLine("Verificando tarjeta....");
        pago.ProcesarPago();
    }
    else
    {
        PagoEfectivo pagoEfectivo = pago as PagoEfectivo;
        Console.WriteLine("Verificando pafo en efectivo....");
        pago.ProcesarPago();

    }

}
