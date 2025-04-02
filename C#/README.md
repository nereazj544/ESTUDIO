# Introducción a C#

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

```
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
<img height="90px" width="100%" src="https://i.pinimg.com/736x/ad/a1/7c/ada17ca329b3fdad8c88d05894323ca6.jpg" >
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

```
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

```
const double PI = 3.14159;
const string MENSAJE = "Este valor no puede cambiar";

```

Las constantes son valores que se establecen durante la compilación y no pueden ser modificados durante la ejecución del programa.

## Características Principales

- **Inmutabilidad:** Una vez declaradas, su valor no puede cambiar
- **Asignación única:** Deben ser inicializadas en el momento de su declaración
- **Tiempo de compilación:** El valor debe ser conocido en tiempo de compilación

## Ejemplos de Uso

```
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

```
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

```
Console.WriteLine(escrito);
```
 Componentes:
- **Console**: clase a la que pertenece el metodo *WriteLine*. 
- **WriteLine**
- **escrito**: cadena de texto que se mostrara en el mensaje mostrado en la consola.

## READLINE

El comando *ReadLine* es utilizado para leer mensajes escritos por los usuarios de las aplicaciones a traves de la consola.
La forma de utilizarlo es la siguiente:

```
CadenaLeida = Console.ReadLine();
```

Componentes:
- **CadenaLeida**: valiable que almacenara la cadena de texto leida mediante el comando.
- **Console**
- **ReadLine**

<br>
<br>
<p align="center">
<img height="90px" width="100%" src="https://i.pinimg.com/474x/e2/42/6f/e2426f8406eaa3c83335b90b0370b537.jpg" >
</p>
<br>
<br>

## FASE 1: Mostrar informacion por pantalla