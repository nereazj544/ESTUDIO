# Introducción a C #

C# (pronunciado "C Sharp") es un lenguaje de programación moderno, orientado a objetos y de tipo seguro desarrollado por Microsoft como parte de la plataforma .NET.

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/ad/a1/7c/ada17ca329b3fdad8c88d05894323ca6.jpg" >
</p>
<br>
<br>

## Características Principales

- **Tipado Fuerte:** C# es un lenguaje de tipado estático, lo que significa que el tipo de cada variable debe ser declarado explícitamente.
- **Orientado a Objetos:** Soporta conceptos como encapsulación, herencia y polimorfismo.
- **Multiplataforma:** Con .NET Core, las aplicaciones C# pueden ejecutarse en Windows, Linux y macOS.
- **Versatilidad:** Puede usarse para desarrollar:
  - Aplicaciones de escritorio
  - Aplicaciones web
  - Juegos (con Unity)
  - Aplicaciones móviles (con Xamarin)
  - APIs y servicios web

## Ventajas

- **Robusto:** Sistema de tipos seguro y gestión automática de memoria.
- **Productivo:** Rica biblioteca de clases y frameworks disponibles.
- **Moderno:** Constantes actualizaciones con nuevas características y mejoras.
- **Gran Comunidad:** Amplio soporte y recursos disponibles para aprendizaje.

## Ejemplo Básico

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("¡Hola, Mundo!");
    }
}

```

<aside>
C# es una excelente opción para desarrolladores que buscan un lenguaje moderno, potente y respaldado por una gran empresa como Microsoft.
</aside>

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/ae/e2/54/aee2544e1aa67cc2806092f2e517266b.jpg" >
</p>
<br>
<br>

# Crear un Proyecto de C# desde la Consola

Para crear un proyecto de C# usando la línea de comandos, necesitarás tener instalado el SDK de .NET en tu sistema. Aquí están los pasos básicos:

## 1. Verificar la Instalación de .NET

```bash
dotnet --version
```

Este comando mostrará la versión de .NET instalada en tu sistema.

## 2. Comandos Básicos para Crear Proyectos

### Crear una nueva aplicación de consola

```bash
dotnet new console -n MiProyecto
```

### Crear una nueva aplicación web

```bash
dotnet new web -n MiProyectoWeb
```

### Crear una nueva aplicación web MVC

```bash
dotnet new mvc -n MiProyectoMVC
```

### Crear clases
```bash
# Crear archivos para las clases
touch Animal.cs
touch Cuidador.cs
touch Zoologico.cs

```

## 3. Estructura del Proyecto

Después de crear el proyecto, se generará una estructura básica que incluye:

- Program.cs - El archivo principal del programa
- NombreProyecto.csproj - El archivo de configuración del proyecto
- obj/ y bin/ - Directorios para archivos compilados y temporales

## 4. Comandos Útiles

Una vez creado el proyecto, puedes usar estos comandos:

```bash
# Compilar el proyecto
dotnet build

# Ejecutar el proyecto
dotnet run

# Restaurar paquetes
dotnet restore
```

## 5. Plantillas Disponibles

Para ver todas las plantillas disponibles:

```bash
dotnet new list
```

## 6. Agregar Paquetes NuGet

Para agregar paquetes externos:

```bash
dotnet add package NombreDelPaquete
```

<aside>
Es importante ejecutar estos comandos en el directorio donde deseas crear tu proyecto o dentro del directorio del proyecto para comandos específicos.
</aside>

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/00/2c/8d/002c8df471e0d94688cb63e0c6324e44.jpg" >
</p>
<br>
<br>

# Objetivo 1: Variables y constantes

## Variable

Las variables son datos que necesitas almacenar y utilizar en los programas y que residen en la memoria del oredanor. Tienen las siguientes características:

- **Nombre**: identificador dentro del codigo fuente que ultilizamos para usarlas.
- **Tipo**: tipo de dato que almacena la variable (numero, entero, cadena de texto, etc)
- **Valor**: valor que almacenan.

## Tipos de Variables Básicos

- **int:** Números enteros (ejemplo: -5, 0, 42)
- **double:** Números decimales de punto flotante (ejemplo: 3.14, -0.001)
- **float:** Números decimales de precisión simple (ejemplo: 3.14f)
- **bool:** Valores booleanos (true/false)
- **char:** Caracteres individuales (ejemplo: 'A', '1', '$')
- **string:** Cadenas de texto (ejemplo: "Hola Mundo")

## Declaración de Variables

```csharp
// Declaración simple
int edad = 25;
string nombre = "Juan";
bool esActivo = true;

// Declaración múltiple
int x = 1, y = 2, z = 3;

// Declaración implícita
var mensaje = "Hola"; // El compilador infiere que es string

```

## Constantes

```csharp
const double PI = 3.14159;
const string MENSAJE = "Este valor no puede cambiar";

```

Las constantes son valores que se establecen durante la compilación y no pueden ser modificados durante la ejecución del programa.

## Características Principales

- **Inmutabilidad:** Una vez declaradas, su valor no puede cambiar
- **Asignación única:** Deben ser inicializadas en el momento de su declaración
- **Tiempo de compilación:** El valor debe ser conocido en tiempo de compilación

## Ejemplos de Uso

```csharp
// Constantes numéricas
const int MAXIMO_INTENTOS = 3;
const double GRAVEDAD = 9.81;

// Constantes de texto
const string MENSAJE_ERROR = "Error en la operación";

// Constantes en una clase
public class Configuracion
{
    const int TIEMPO_ESPERA = 1000;
    const string VERSION = "1.0.0";
}

```

## Cuándo Usar Constantes

- **Valores matemáticos:** Como π, conversiones de unidades, etc.
- **Configuración:** Valores que no deben cambiar en toda la aplicación
- **Mensajes:** Textos predefinidos que se usan en múltiples lugares
- **Límites:** Valores máximos o mínimos establecidos

<aside>
A diferencia de las variables readonly, las constantes deben tener un valor conocido en tiempo de compilación y son siempre estáticas (static) implícitamente.
</aside>

## Tipos Nullable

Permiten que las variables contengan un valor null además de su tipo de dato normal:

```csharp
int? numeroNullable = null;
string? textoNullable = null;

```

## Variables de Referencia vs Valor

- **Tipos de valor:** int, double, bool, char, struct
- **Tipos de referencia:** string, class, interface, delegate, array

<aside>
Es importante recordar que las variables deben ser inicializadas antes de ser utilizadas y que C# es un lenguaje de tipado fuerte, lo que significa que una vez que se declara una variable de un tipo, no puede cambiar su tipo.
</aside>

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/474x/e2/42/6f/e2426f8406eaa3c83335b90b0370b537.jpg" >
</p>
<br>
<br>

# Objetivo 2: Manejo de mensajes por pantalla

Mostrar información por pantalla y leer información de los usuarios son operadores necesarias para conseguir una interactividad alta con las aplicaciones que desarrolles por parte de los usuarios de éstas.

## WRITE

El comando *Write* es utilizado para escribrir mensajes por pantalla en la consola sin introducir salto de linea a final. La forma de utilizarlo es la siguiente:

```
Console.Write(escrito);
```

 Componentes:

- **Console**: clase a la que pertenece el metodo *Write*.
- **Write**
- **escrito**: cadena de texto que se mostrara en el mensaje mostrado en la consola.

## WRITELINE

El comando *Writeline* es utilizado para escribir mensajes por pantalla en la consola introducciendo un salto al final del mismo.
La forma de utilizarlo es la siguiente:

```csharp
Console.WriteLine(escrito);
```

 Componentes:

- **Console**: clase a la que pertenece el metodo *WriteLine*.
- **WriteLine**
- **escrito**: cadena de texto que se mostrara en el mensaje mostrado en la consola.

## READLINE

El comando *ReadLine* es utilizado para leer mensajes escritos por los usuarios de las aplicaciones a traves de la consola.
La forma de utilizarlo es la siguiente:

```csharp
CadenaLeida = Console.ReadLine();
```

Componentes:

- **CadenaLeida**: valiable que almacenara la cadena de texto leida mediante el comando.
- **Console**
- **ReadLine**

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/8c/24/dc/8c24dc8885c659c829a74cc42d831f10.jpg" >
</p>
<br>
<br>

## FASE 1: Mostrar informacion por pantalla

El primer ejercicio de la base de la fase consiste en comprobar qué la utilización de *WriteLine* sé diferencias de *Write* en que añade un salto de línea al final del mensaje al ejecutar la sentencia.

```csharp
// TODO Fase 1: Mostrar informacion por pantalla | Ej. 1
Console.Write("Hola, ¿que haces? ¿como estas? ¿como tas?");
Console.WriteLine(); //! Este puede ir vacio (o no) ⤴️ no puede ir vacio 
Console.WriteLine("Hola");  
Console.WriteLine("¿que haces?");  
// Console.ReadLine();
```

Se ha introducido una sentencia *ReadLine* al final del código fuente esto lo hacen lo hemos hecho para que no se cierre la aplicación y puedas observar la salida por pantalla para finalizar el programa presiona *enter* (o escribe algo y dale al enter).

El segundo ejercicio de la fase consiste en aprender a añadir texto promeniente de variables a los mensajes que se muestran y cómo utilizar caracteres especiales dentro de los usajes que se muestran.

```csharp
// TODO Fase 1: Mostrar informacion por pantalla | Ej. 2
Console.WriteLine("Hola mi alias es: " + nombre);
Console.WriteLine("Hola mi alias es: {0}\n", nombre); //! Este es muy similar a cuando se formatea el mensaje en java
Console.WriteLine("Hola mi alias es: \"{0}\"  ", nombre);
```

La primera sentencia permite formar cadenas mediante concatentación ("+") de cadenas.

>[!NOTE]
>
> Al igual que sucede con **java**

La segunda sentencia permite formar una cadena mediante la introducción de valores en una cadena primitiva. <br>
La forma en la que funciona es mediante el reemplazo de una cadena de texto específica que se encuentra dentro de la cadena primitiva por el valor correspondiente que se indica en la construcción de la cadena, sigue el siguiente formato: **{n}**. <br>
El valor **n** indica la cadena concreta por la que se reemplazará del listado de cadenas al introducir en la cadena primitiva el primer valor que tomará **n** es el **cero**.

>[!NOTE]
>
> Es como los arrays en java que empiezan por 0....10

Se ha introducido el carácter **\n** Que añade un salto de linea a la cadena.

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/24/e1/20/24e12077ac44c5f7a5b847a794b3fd16.jpg" >
</p>
<br>
<br>

## FASE 2: Leer informacion desde teclado

La segunda fase del objetivo consiste en leer información introducida por los usuarios de las aplicaciones en el teclado. <br>
La sentencia para leer información a través del teclado es *ReadLine* todo lo que se introduzca mediante teclado será almacenado en la variable que es principemos una vez el usuario presione la tecla *enter*.

```csharp
// TODO Fase 2: Leer inforacion desde teclado
// ! Por asi decirlo es lo mismo que poner un Scanner.
Console.Write("Como te llamas?");
string name = Console.ReadLine();
Console.Write("tienes perro o mascota?");
string r = Console.ReadLine();
Console.WriteLine("HOLA! " + name + " tu respuesta a la pregunta: " + r + "\n");
```

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/2c/4c/ff/2c4cffc5749394b7ac689f136f271ca8.jpg" >
</p>
<br>
<br>

# Objetivo 3: Tipos de datos basicos y operados

Diferentes tipos de datos que existen en C#. En la primera se utilizan los números de diferentes operaciones aritméticos y en la segunda los tipos de datos booleanos y los diferentes operadores lógicas.

## Tipo de datos

### Tipos Numéricos

- **byte:** 0 a 255 (8 bits sin signo)
- **short:** -32,768 a 32,767 (16 bits)
- **int:** -2^31 a 2^31-1 (32 bits)
- **long:** -2^63 a 2^63-1 (64 bits)
- **float:** ±1.5 × 10^-45 a ±3.4 × 10^38 (32 bits)
- **double:** ±5.0 × 10^-324 a ±1.7 × 10^308 (64 bits)
- **decimal:** Mayor precisión para cálculos financieros (128 bits)

## Operadores en C #

### Operadores de Asignación

- **=** Asignación simple
- **+=** Suma y asignación
- **-=** Resta y asignación
- ***=** Multiplicación y asignación
- **/=** División y asignación

### Operadores Aritméticos

- **+** Suma
- **-** Resta
- ***** Multiplicación
- **/** División
- **%** Módulo (resto de división)
- **++** Incremento
- **--** Decremento

### Operadores Relacionales

- **==** Igual a
- **!=** Diferente de
- **>** Mayor que
- **<** Menor que
- **>=** Mayor o igual que
- **<=** Menor o igual que

### Operadores Lógicos

- **&&** AND lógico
- **||** OR lógico
- **!** NOT lógico
- **^** XOR lógico

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/a9/ff/6a/a9ff6a88c6d7e6ce2d5127736da635ad.jpg" >
</p>
<br>
<br>

## FASE 1: NUMEROS Y OPERADORES ARITMETICOS

### Suma

Realizar una suma de números enteros y una suma de números reales que son solicitados al usuario. <br><br>
Para transformar los valores leídos a 1 bueno entero tienes que hacerlo de la siguiente forma:

```csharp
Convert.ToInt32(System.Console.ReadLine());
```

Para transformar los valores leídos a números reales tienes que hacerlo de la siguiente forma:

```csharp
Convert.ToDecimal(System.Console.ReadLine());
```

### EJERCICIOS DE LA FASE 1

```csharp
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
```

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/53/92/51/539251a7f61089bc88407c7884c08f9f.jpg">
</p>
<br>
<br>

## FASE 2: Booleanos y operdoderes logicos / relacionales

```csharp
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
Console.Write(num1 + "<" + num2 + ": " + (num1 < num2));
Console.Write(num1 + ">=" + num2 + ": " + (num1 >= num2));
Console.Write(num1 + "<=" + num2 + ": " + (num1 <= num2));
Console.Write(num1 + "==" + num2 + ": " + (num1 == num2));
Console.Write(num1 + "!=" + num2 + ": " + (num1 != num2));
```

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/d8/3d/4f/d83d4fcb95583f75c4181f689b705786.jpg" >
</p>
<br>
<br>

# Objetivo 4: Cadena de texto

La utilizacion de cadena de texto. <br> Diferentes metodos utiles que se permitiran realizar operaciones complejas, unicamente con una instruccion. Dichas instrucciones son propias del tipo de dato cadena de texto.

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/5d/90/28/5d9028e745277942a61c2904bb64593a.jpg" >
</p>
<br>
<br>

## FASE 1: Metodos propios de la clase

- **ToUpper()**: Convierte todos los caracteres de la cadena a mayúsculas.

    ```csharp
    string texto = "hola";
    string mayusculas = texto.ToUpper(); // Resultado: "HOLA"
    ```

- **ToLower()**: Convierte todos los caracteres de la cadena a minúsculas.

    ```csharp
    string texto = "HOLA";
    string minusculas = texto.ToLower(); // Resultado: "hola"
    ```

- **Concat()**: Permite concatenar cadenas una tras otra.

    ```csharp
    string str1 = "Hola ";
    string str2 = "Mundo";
    string resultado = string.Concat(str1, str2); // Resultado: "Hola Mundo"
    ```

- **Format()**: Permite formar cadenas mediante sustituciones de marcadores.

    ```csharp
    string nombre = "Juan";
    int edad = 25;
    string resultado = string.Format("Me llamo {0} y tengo {1} años", nombre, edad);
    ```

- **StartsWith()**: Verifica si la cadena comienza con un texto específico. Devuelve True o False.

    ```csharp
    string texto = "Hola Mundo";
    bool empiezaCon = texto.StartsWith("Hola"); // Resultado: true
    ```

- **EndsWith()**: Verifica si la cadena termina con un texto específico. Devuelve True o False.

    ```csharp
    string texto = "Hola Mundo";
    bool terminaCon = texto.EndsWith("Mundo"); // Resultado: true
    ```

- **Equals()**: Compara si dos cadenas son iguales. Devuelve True o False.

    ```csharp
    string str1 = "hola";
    string str2 = "hola";
    bool sonIguales = str1.Equals(str2); // Resultado: true
    ```

- **Substring()**: Permite obtener una subcadena. Recibe la posición inicial y opcionalmente la longitud.

    ```csharp
    string texto = "Hola Mundo";
    string sub1 = texto.Substring(5);    // Resultado: "Mundo"
    string sub2 = texto.Substring(0, 4); // Resultado: "Hola"
    ```

- **TrimStart()**: Elimina los espacios en blanco (u otros caracteres especificados) del inicio de la cadena.

    ```csharp
    string texto = "   Hola   ";
    string resultado = texto.TrimStart(); // Resultado: "Hola   "
    ```

- **TrimEnd()**: Elimina los espacios en blanco (u otros caracteres especificados) del final de la cadena.

    ```csharp
    string texto = "   Hola   ";
    string resultado = texto.TrimEnd(); // Resultado: "   Hola"
    ```

- **Trim()**: Elimina los espacios en blanco (u otros caracteres especificados) del inicio y final de la cadena.

```csharp
string texto = "   Hola   ";
string resultado = texto.Trim(); // Resultado: "Hola"
```

## Más informacion acerca de las cadenas de texto

### Declaración de Strings

```csharp
// Declaración básica
string texto = "Hola mundo";

// String vacío
string cadenaVacia = "";
string otraCadenaVacia = string.Empty;

// String literal con @
string ruta = @"C:\carpeta\archivo.txt";

// String interpolado
string nombre = "Juan";
string saludo = $"Hola {nombre}";
```

### Operaciones Comunes

- **Concatenación:** Usando el operador + o el método String.Concat()
- **Subcadenas:** Usando el método Substring()
- **Búsqueda:** Con IndexOf(), Contains(), StartsWith(), EndsWith()
- **Modificación:** Replace(), Trim(), ToUpper(), ToLower()

### Métodos Útiles

```csharp
string texto = "  Ejemplo de texto  ";
texto = texto.Trim();           // Elimina espacios
texto = texto.ToUpper();        // Convierte a mayúsculas
int longitud = texto.Length;    // Obtiene la longitud
bool contiene = texto.Contains("de");  // Busca una subcadena
```

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/b6/37/7d/b6377d7575ae53bf28b570d37608c2d0.jpg" >
</p>
<br>
<br>

# Objetivo 5: Colecciones

Las colecciones son las siguientes:

- Arrays
- Listas
- Dicionarios

## Arrays

Los arrays son colecciones de tamaño fijo que almacenan elementos del mismo tipo.

```csharp
// Declaración e inicialización de arrays
int[] numeros = new int[5];
string[] nombres = { "Ana", "Carlos", "María" };

// Acceso a elementos
int primerNumero = numeros[0];

// Longitud del array
int longitud = numeros.Length;

Listas (List)
```

Las listas son colecciones dinámicas que pueden crecer o reducirse según sea necesario.

```csharp
// Crear una lista
List<string> frutas = new List<string>();

// Agregar elementos
frutas.Add("Manzana");
frutas.Add("Banana");

// Remover elementos
frutas.Remove("Manzana");

// Verificar si contiene un elemento
bool contiene = frutas.Contains("Banana");

// Obtener cantidad de elementos
int cantidad = frutas.Count;
```

## Diccionarios (Dictionary<TKey, TValue>)

Los diccionarios almacenan pares clave-valor, donde cada clave debe ser única.

```csharp
// Crear un diccionario
Dictionary<string, int> edades = new Dictionary<string, int>();

// Agregar elementos
edades.Add("Juan", 25);
edades["María"] = 30;

// Acceder a valores
int edadJuan = edades["Juan"];

// Verificar si existe una clave
bool existe = edades.ContainsKey("Juan");

// Eliminar un elemento
edades.Remove("Juan");
```

## Métodos Comunes

- **Arrays:** Sort(), Reverse(), Clear(), Copy()
- **Listas:** AddRange(), Insert(), RemoveAt(), Sort(), Clear()
- **Diccionarios:** TryGetValue(), ContainsValue(), Clear(), Keys, Values

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/d0/eb/9f/d0eb9f0549f2d54b9e247eb79c79cb68.jpg">
</p>
<br>
<br>

# Objetivo 6: Control flujo de programa

El control de flujo en C# permite dirigir la ejecución del programa basándose en condiciones y decisiones. Esto es fundamental para crear programas dinámicos y responder a diferentes situaciones.

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/474x/7f/a2/d0/7fa2d09e1114e1e97176569b65e2db80.jpg">
</p>
<br>
<br>

## FASE 1: IF

La sentencia if es la estructura de control más básica y permite ejecutar código basado en una condición booleana.

```csharp
// If simple
if (edad >= 18) {
    Console.WriteLine("Es mayor de edad");
}

// If-else
if (numero > 0) {
    Console.WriteLine("Número positivo");
} else {
    Console.WriteLine("Número negativo o cero");
}

// If-else if-else
if (nota >= 90) {
    Console.WriteLine("A");
} else if (nota >= 80) {
    Console.WriteLine("B");
} else if (nota >= 70) {
    Console.WriteLine("C");
} else {
    Console.WriteLine("D");
}

```

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/474x/c8/6d/6c/c86d6c487d345d32247ef3b0e87f572c.jpg">
</p>
<br>
<br>

## FASE 2: Switch

La sentencia switch es útil cuando necesitas comparar una variable contra múltiples valores constantes.

```csharp
int dia = 3;
switch (dia) {
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miércoles");
        break;
    default:
        Console.WriteLine("Otro día");
        break;
}

// Switch con expresiones (C# 8.0+)
string mensaje = dia switch {
    1 => "Lunes",
    2 => "Martes",
    3 => "Miércoles",
    _ => "Otro día"
};

```

<aside>
El switch es más eficiente que múltiples if-else cuando se compara una única variable contra varios valores constantes. Sin embargo, if-else es más flexible para condiciones complejas.</aside>

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/ea/70/c5/ea70c55e8b3e30131db34a7c493883ac.jpg">
</p>
<br>
<br>

# Objetivo 7: Bucles

## FASE 1: While

El bucle while ejecuta un bloque de código mientras una condición sea verdadera.

```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

```

## FASE 2: For

El bucle for es ideal cuando sabes exactamente cuántas iteraciones necesitas.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

```

## FASE 3: Do

El bucle do-while ejecuta el código al menos una vez antes de verificar la condición.

```csharp
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);

```

## FASE 4: Bucles Anidados

Los bucles anidados son bucles dentro de otros bucles.

```csharp
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"i: {i}, j: {j}");
    }
}

```

## FASE 5: FOREACH

El bucle foreach se utiliza para iterar sobre colecciones.

```csharp
string[] frutas = {"manzana", "banana", "naranja"};
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

```

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/474x/0e/8a/36/0e8a36dd2f2e0de2224977f1523b4f6b.jpg">
</p>
<br>
<br>

# Objetivo 8: Funciones

## FASE 1: Uso de una funcion

## FASE 2: Funciones anidadas

C# permite el uso de funciones locales (funciones dentro de otras funciones).

```csharp
public static int CalculoComplejo(int x)
{
    int CuadradoLocal(int n)
    {
        return n * n;
    }

    return CuadradoLocal(x) + x;
}

```

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/40/8f/ca/408fca06b23a4ada885df9ccacb0b177.jpg">
</p>
<br>
<br>

# Objetivo 9: Programacion orientada a objetos basica

## FASE 1: Clases simples

Las clases son plantillas para crear objetos.

```csharp
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre}");
    }
}

```

## FASE 2: Composición

La composición permite crear clases que contienen otras clases.

```csharp
public class Dirección
{
    public string Calle { get; set; }
    public string Ciudad { get; set; }
}

public class Empleado
{
    public string Nombre { get; set; }
    public Dirección Dirección { get; set; }
}

```

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/42/79/84/42798486fabb3644e5b6470a35bb8455.jpg">
</p>
<br>
<br>

# Objetivo 10: Programacion orientada objetos avanzados

## FASE 1: Herencia

La herencia permite crear nuevas clases basadas en clases existentes.

```csharp
public class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("Sonido genérico");
    }
}

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("¡Guau!");
    }
}

```

## FASE 2: Polimorfismo

El polimorfismo permite tratar objetos de diferentes clases de manera uniforme.

```csharp
Animal[] animales = new Animal[]
{
    new Perro(),
    new Gato()
};

foreach (Animal animal in animales)
{
    animal.HacerSonido(); // Cada animal hace su sonido específico
}

```

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/736x/a3/48/bb/a348bb4202bfce0a57963a07cb649814.jpg">
</p>
<br>
<br>

# Objetivo 11: Control de excepciones

## FASE 1: Controlando excepciones

El manejo de excepciones permite controlar errores en tiempo de ejecución.

Las funciones son bloques de código reutilizables que realizan una tarea específica.

```csharp
public static int Suma(int a, int b)
{
    return a + b;
}

// Uso de la función
int resultado = Suma(5, 3);

```
