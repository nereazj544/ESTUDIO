// See https://aka.ms/new-console-template for more information

// TODO Simple

string nombre = "Neo";


// TODO multiple

// int x = 1, y = 3, z = 10;

// TODO Declaracion implicita
// var mensaje = "Hola";


// TODO Constantes
// const string md = "NO SE PUEDE CAMBIAR";

// TODO Nullable
// int? numNull = null;


// TODO Escribir por pantalla

Console.Write(nombre);
Console.WriteLine();

// TODO Fase 1: Mostrar informacion por pantalla | Ej. 1
Console.Write("Hola, ¿que haces? ¿como estas? ¿como tas?");
Console.WriteLine(); //! Este puede ir vacio (o no) ⤴️ no puede ir vacio 
Console.WriteLine("Hola");
Console.WriteLine("¿que haces?");
// Console.ReadLine();


// TODO Fase 1: Mostrar informacion por pantalla | Ej. 2
Console.WriteLine("Hola mi alias es: " + nombre);
Console.WriteLine("Hola mi alias es: {0}\n", nombre); //! Este es muy similar a cuando se formatea el mensaje en java
Console.WriteLine("Hola mi alias es: \"{0}\"  ", nombre);


// TODO Fase 2: Leer inforacion desde teclado
// ! Por asi decirlo es lo mismo que poner un Scanner.

Console.Write("Como te llamas?");
string name = Console.ReadLine();
Console.Write("tienes perro o mascota?");
string respuesta1 = Console.ReadLine();
Console.WriteLine("HOLA! " + name + " tu respuesta a la pregunta: " + respuesta1 + "\n");

//? Esto no tiene nada que ver con la fase 2, lo hice porque me apetecia.
switch (respuesta1)
{
    case "no":
        Console.Write(":(\n");
        break;
    case "si":
        Console.Write("\nOh muy bien! \n En mi caso tengo perro");
        break;
    default:
        Console.Write("\n No se ha introduccido algo valido");
        break;
}


// TODO FASE 1: NUMEROS Y OPERADORES ARITMETICOS | Suma, resta, multiplicacion, resta, division, modulo, uso de parentesis
Console.WriteLine("Que quieres hacer {0}", name);
Console.WriteLine("## OPCIONES ##");
Console.WriteLine("1. Suma \n" +
"2. Resta \n" +
"3. Multiplicar \n" +
"4. Division \n" +
"5. Modulo \n" +
"6. Uso de parentesis \n" +
"7. Uso de decimales \n"
);

int respuesta2 = Convert.ToInt32(Console.ReadLine());

switch (respuesta2)
{
    case 1:
        Sumar();
        break;
    case 2:
        Restar();
        break;
    case 3:
        Multiplicar();
        break;
    case 4:
        Division();
        break;
    case 5:
        Modulo();
        break;
    case 6:
        UsoParentesis();
        break;

    case 7:
        NumDecimales();
        break;



    default:
        Console.Write("NO ES LA RESPUESTA QUE SE ESPERABA");
        break;
}



// TODO CREACION DE METODOS
void Sumar()
{
    string opcion = "sumar";
    Console.Write("## SE HA SELECIONADO LA OPCION {0} ## \n", opcion);

    Console.Write("NUMERO 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("NUMERO 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int r = num1 + num2;
    Console.WriteLine("RESULTADO: " + r);
}

void Restar()
{
    string opcion = "restar";
    Console.Write("## SE HA SELECIONADO LA OPCION {0} ## \n", opcion);

    Console.Write("NUMERO 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("NUMERO 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int r = num1 - num2;
    Console.WriteLine("RESULTADO: " + r);
}

void Multiplicar()
{
    string opcion = "Multiplicar";
    Console.Write("## SE HA SELECIONADO LA OPCION {0} ## \n", opcion);

    Console.Write("NUMERO 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("NUMERO 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int r = num1 * num2;
    Console.WriteLine("RESULTADO: " + r);
}

void Division()
{
    string opcion = "Division";
    Console.Write("## SE HA SELECIONADO LA OPCION {0} ## \n", opcion);

    Console.Write("NUMERO 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("NUMERO 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int r = num1 / num2;
    Console.WriteLine("RESULTADO: " + r);
}
void Modulo()
{
    string opcion = "Modulo";
    Console.Write("## SE HA SELECIONADO LA OPCION {0} ## \n", opcion);

    Console.Write("NUMERO 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("NUMERO 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int r = num1 % num2;
    Console.WriteLine("RESULTADO: " + r);
}
void UsoParentesis()
{
    string opcion = "Uso Parentesis";
    Console.Write("## SE HA SELECIONADO LA OPCION {0} ## \n", opcion);

    Console.Write("NUMERO 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("NUMERO 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("NUMERO 1: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    Console.Write("NUMERO 2: ");
    int num4 = Convert.ToInt32(Console.ReadLine());
    int r = (num1 * num2) - num4 + num3;
    Console.WriteLine("RESULTADO: " + r);
}

void NumDecimales()
{
    string opcion = "sumar / Con numeros Decimales";
    Console.Write("## SE HA SELECIONADO LA OPCION {0} ## \n", opcion);

    Console.Write("NUMERO 1: ");
    decimal num1 = Convert.ToDecimal(Console.ReadLine());
    Console.Write("NUMERO 2: ");
    decimal num2 = Convert.ToInt32(Console.ReadLine());
    decimal r = num1 + num2;
    Console.WriteLine("RESULTADO: " + r);
}

