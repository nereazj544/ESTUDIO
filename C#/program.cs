using ConsoleApp1_Practica;
using System;


//! NOTA: ctrl + D duplica la linea, alt + flechas bajar/subir, sift + alt + flecha se crea el multi cursor


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); //? Salto de linea
        string fristName = Console.ReadLine(); //? Lee una cadena de texto
        string name2 = " _ ";
        Console.WriteLine("Nombre: {0}", fristName); //? Muestra por pantalla el nombre (v1 de mostar datos)
        Console.WriteLine("Nombre: {0}", fristName); //? Muestra por pantalla el nombre (v2 de mostar datos)
        
        //! Concatenaciones
        String text = fristName + name2;
        Console.WriteLine(text);

        //? interpolacion 
        string text2 = $"text test: {fristName}";
        Console.WriteLine(text2);



        //! Boolean 
        bool isTrue = true;
        bool isFalse = false;


        //! For and For Each
        //? For Each sirve para recorrer arrays. For control de mostrar el dato
        string [] myCharacter = {"Raian", "Aiden", "Will"};
        
        for (int i = 1; i < 3; i++)
            {
        foreach ( string chara in myCharacter)
        {
                 Console.WriteLine("> Character {0}: {1} ", i++, chara);
            }
        }

        //! If Else
        int myNumber1 = 3;
        int myNumber2 = 5;

        if (myNumber1 < myNumber2) {
            Console.WriteLine("num 1: {0} < num2: {1}", myNumber1, myNumber2) ;
        } else if (myNumber1 == myNumber2) { 
            Console.WriteLine("num 1: {0} == num2: {1}", myNumber1, myNumber2) ;
        }
        else
        {
            Console.WriteLine(isFalse);
        }

        //! Short if else
        int myInt = 40;
        string reslt = (myInt < 29) ? "God" : "Not";
        Console.WriteLine(reslt);

        //Continue 
        int myInt2 = 5;
        while (myInt2 <= 5) {

            if (myInt2 == 5)
            {
                //lo va a incrementar
                myInt2++;
                continue;  //! Continua con la ejecucion del codigo
            }
            Console.WriteLine(myInt2);
        }

        //! switch +  Metodos invocacion
        Console.WriteLine("## OPCIONES ##");
        Console.WriteLine("1- List \n 2- Diccinary");
        
        int resultQuestion = Convert.ToInt32(Console.ReadLine());

        switch (resultQuestion)
        {
            case 1:
                Console.WriteLine("List");
               listMethod();
                break; //? Break rompe el switch y no ejecuta el resto de los casos

            case 2:
                Console.WriteLine("Diccionary");
                dictionaryMethod();
                break;

            default:
                Console.WriteLine("No hay opciones validas");
                break;
        }

        MyMethot("c");

        //! Referencias a clases
        //ConsoleApp1_Practica.myCars cars1 = new ConsoleApp1_Practica.myCars("Maza", "RX7", ConsoleApp1_Practica.myCars.myMotor.GASOLINA, 2005);
        //List<myCars> listCars = new List<myCars>();
        //listCars.Add(cars1);
        //Console.WriteLine(listCars[0].ToString());


        MyCar car1 = new MyCar("Mazda", "RX7", MyCar.myMotor.GASOLINA, 2005);
        MyCar car2 = new MyCar("Mazda", "RX8", MyCar.myMotor.DIESEL, 2008);
        List<MyCar> listCars = new List<MyCar>();

        

        //! Invocar funciones
        Sumar();
    }

    private static void MyMethot(string myString)
    {
        Console.WriteLine(myString);
    }

    //! Funciones
    private static void dictionaryMethod()
    {
        Console.WriteLine("crear lista");
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        bool isExit = true;

        while (isExit)
        {
            Console.WriteLine("\n1- Agregar \n 2- Mostrar \n 3- Salir");
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case 1:
                    Console.WriteLine("Agregar elemento (numero id) - despues de introduccir el numero meta datos escritos (nombre, cosas) ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    myDictionary.Add(id, Console.ReadLine());
                    //string element = Console.ReadLine();
                    //myDictionary.Add(id, element);
                    break;
                case 2:
                    Console.WriteLine("Mostrar datos del diccionario");
                    foreach(KeyValuePair<int, string> item in myDictionary)
                    {
                        Console.WriteLine("> ID: {0}, Nombre: {1}", item.Key, item.Value);
                    }
                    break;
                case 3:
                    isExit = false;
                    break;
                default:
                    Console.WriteLine("No hay opciones validas");
                    break;
            }

        }

    }


    private static void listMethod()
    {
        Console.WriteLine("crear lista");
        List<string> myList = new List<string>();

        bool isExit = true;

        while (isExit)
        {
            Console.WriteLine("1- Agregar \n 2- Mostrar \n 3- Salir");
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case 1:
                    Console.WriteLine("Agregar elemento: ");
                    string element = Console.ReadLine();
                    myList.Add(element);
                    break;
                case 2:
                    foreach (string item in myList)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 3:
                    isExit = false;
                    break;
                default:
                    Console.WriteLine("No hay opciones validas");
                    break;
            }

        }


    }

    private static void Sumar()
    {
        Console.WriteLine("> Numero entero: ");
        int number1 = Convert.ToInt32(Console.ReadLine()); //? Lectura de un numero entero
        Console.WriteLine("> Numero decimal: ");
        double number2Double = Convert.ToDouble(Console.ReadLine()); //? Lectura de numero decimal
        int result = (int) (number1 + number2Double);
        Console.WriteLine(">Numero 1: {0}, \n > Numero 2: {1} \n> Resultado: {2}", number1, number2Double, result);

    }
}

public class MyCar
{
        //! Tipos
        public enum myMotor
        {
            GASOLINA, DIESEL, HIBRIDO, ELECTRONICO
        }
        private myMotor typeMotor;
        private string myMarca;
        private string myModel;
        private int myYearOfMade;

        public MyCar(string myMarca, string myModel, myMotor motor, int dateMade)
        {
            if (myYearOfMade > 0)
            {
                this.myMarca = myMarca;
                this.myModel = myModel;
                this.typeMotor = motor;
                this.myYearOfMade = dateMade;
            }
        }
    }
