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

// TODO FASE 2: Booleanos y operdoderes logicos / relacionales

bool v1 = true;
bool v2 = false;
//! Booleanos
Console.Write("\n> Valor 1: " + v1 + "\n> Valor 2: " + v2);

//! Operdares
Console.Write("\nOPERDADOR AND");
Console.Write("\n> Valor TRUE && Valor TRUE = " + (v1 && v1));
Console.Write("\n> Valor TRUE && Valor FASLE = " + (v1 && v2));
Console.Write("\n> Valor FALSE && Valor FASLE = " + (v2 && v2));
Console.Write("\nOPERDADOR OR");
Console.Write("\n> Valor TRUE || Valor TRUE = " + (v1 || v1));
Console.Write("\n> Valor TRUE || Valor FASLE = " + (v1 || v2));
Console.Write("\n> Valor FALSE || Valor FASLE = " + (v2 || v2));
Console.Write("\nOPERDADOR NOT");
Console.Write("\n> NOT Valor TRUE = " + (!v1));
Console.Write("\n> NOT Valor FALSE = " + (!v2));
Console.Write("\nOPERDADORES RELACIONALES");
Console.Write("NUMERO 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("NUMERO 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write(num1 + ">" + num2 + ": " + (num1 > num2));
Console.WriteLine();
Console.Write(num1 + "<" + num2 + ": " + (num1 < num2));
Console.WriteLine();
Console.Write(num1 + ">=" + num2 + ": " + (num1 >= num2));
Console.WriteLine();
Console.Write(num1 + "<=" + num2 + ": " + (num1 <= num2));
Console.WriteLine();
Console.Write(num1 + "==" + num2 + ": " + (num1 == num2));
Console.WriteLine();
Console.Write(num1 + "!=" + num2 + ": " + (num1 != num2));
Console.WriteLine();


// TODO FASE 1: Cadena de texto
string text = "Ojalá no fuese tuya esta canción";

Console.WriteLine("Orginial: " + text);
Console.WriteLine("Tamaño: " + text.Length);
Console.WriteLine("Mayus: " + text.ToUpper());
Console.WriteLine("Minus: " + text.ToLower());

// !  NO ENTIENDO ESTO, si lo entiendo pero no tiene sentido
// Definimos tres líneas de texto
string text1 = "Lo que pasó entre tú y yo";
string text2 = "Fue lindo mientras duró";
string text3 = "Y no me arrepiento, aunque ya no quede nada";

// Método 1: Usando string.Concat() con saltos de línea
string conct = string.Concat(text1, "\n", text2, "\n", text3);

// Método 2: Usando el operador + con saltos de línea
string cv2 = text1 + "\n" + text2 + "\n" + text3;

// Mostramos el resultado de ambos métodos (serán idénticos)
Console.WriteLine(conct);
Console.WriteLine();  // Línea en blanco
Console.WriteLine(cv2);
Console.WriteLine();  // Línea en blanco

// Usando string.Format() para crear una cadena con marcadores
string text4 = "La cadena tiene {0} lineas. \n La primera la ha escrito {1}, la segunda la escrito {2}";
string cadena = string.Format(text4, 3, "Tini", "tini");
Console.WriteLine(cadena);


// TODO FASE 1: Arrays
string cadEspacios = "Fue lindo mientras duró";
string[] a = cadEspacios.Split(' ');

Console.WriteLine("Cadena or " + cadEspacios);
Console.WriteLine(a[0]);
Console.WriteLine(a[1]);
Console.WriteLine(a[2]);
Console.WriteLine(a[3]);

string cadSep = "Amanda,Epsilon,nija,soldado";
char[] sep = { ',' };

a = cadSep.Split(sep);
Console.WriteLine(a[0]);
Console.WriteLine(a[1]);
Console.WriteLine(a[2]);
Console.WriteLine(a[3]);


int[] nums = { 5, 10, 15, 20, 25, 30 }; //! los arrays con los numero es el corchete antes del nombre de la variable
Console.WriteLine("NUMEROS: " + nums[0] + ","
+ nums[1] + ","
+ nums[2] + ","
+ nums[3] + ","
+ nums[4] + ","
+ nums[5]);

nums[1] = 13;
nums[4] = nums[5] - 9;
Console.WriteLine("Num elementos: " + nums.Length);

Array.Sort(nums);

Console.WriteLine("Ordenados " + nums[0] + ","
+ nums[1] + ","
+ nums[2] + ","
+ nums[3] + ","
+ nums[4] + ","
+ nums[5]);

Console.WriteLine("¿existe el elemento 80? " + Array.IndexOf(a, 80));
Console.WriteLine("¿existe el elemento 10? " + Array.IndexOf(a, 13));


// TODO FASE 1: Lista

List<string> personajes = new List<string>(); //? forma uno
List<string> per2 = new List<string> { "Raian", "Aiden", "Will" };
List<int> listEnt = new List<int> { 1, 2, 3, 4, 5 }; //? forma dos

//? Agregar elementos
personajes.Add("Kaito");
listEnt.Add(28);
personajes.Insert(1, "Akira");
personajes.Insert(2, "Bill");

Console.WriteLine("Contenido de la lista: Personajes: " +
personajes[0] + ","
+ personajes[1] + ","
+ personajes[2] + ","
+ " Cantidad: " + personajes.Count);

Console.WriteLine("Contenido de la lista: Personajes 2: " +
per2[0] + ","
+ per2[1] + ","
+ per2[2] + ","
+ " Cantidad: " + per2.Count);

//? Remover elementos
listEnt.Remove(3); //! borra el elemento selecionado
listEnt.RemoveAt(0); //! borra la posicion (en este caso el primer elemento)
per2.Clear(); //! Borra todo

// ? Verificar
bool vf = personajes.Contains("Bill");
Console.WriteLine("¿existe el elemento \"Bill\"? " + vf);

//? Cnaridad
int cant = listEnt.Count;
int cant2 = per2.Count;
Console.WriteLine("¿cantidad? " + cant);
Console.WriteLine("¿cantidad? " + cant2);

// TODO LISTA DENTRO DE OTRA LISTA
List<List<int>> ints = new List<List<int>> {new List<int>{1,2,3}, new List<int>{34, 78, 78}};
Console.WriteLine("n de elementos? " + ints.Count);

Console.WriteLine("n de elementos?(primera lista) " + ints[0].Count);

Console.WriteLine("elementos(primera lista) " 
+ ints[0][0] + ","
+ ints[0][1] + ","
+ ints[0][2] + ","
);

Console.WriteLine("elementos(primera lista) " 
+ ints[1][0] + ","
+ ints[1][1] + ","
+ ints[1][2] + ","
);



//TODO FASE 1: Diccionarios






