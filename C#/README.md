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
