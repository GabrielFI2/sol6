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
