fun main() {
    // TODO Mostrar mensjaes por pantalla
    println("Hola Koltin")

    // TODO MoureDev by Brais Moure

    // TODO Sintaxis

    // ? Variables > Son las que se pueden variar
    var myString = "Esto es una cadena de texto"
    println(myString)
    myString = "Cambio de cadena"
    println(myString)

    var myString2: String = "esto es con tipacion"

    var myInt = 9 // numeros interos
    myInt = myInt - 3
    println(myInt)
    println(myInt + 4)

    var myDouble = 3.4 // ? Numeros decimales
    myDouble = 9.0

    // ! EVITAR TIPAR PERO ES PARA VER EL TIPO DE DATO VIENE BIEN
    var myFloat: Float = 5.2f
    myFloat - 4f

    var myBoolean = true // ? Esto solo falso o verdadero

    // TODO Constantes
    //! ESTAS NO VARIAN
    val myConst = "Mi propiedad constetante"
    //    ! ERROR myConst = "mi nueva prop";

    //    todo control de flujo

    myInt = 40
    myString = "Pito"
    if (myInt == 40 && myString == "Hola") {
        println("El valor es 40 ")
        println("El valor es 'Hola'")
    } else if (myInt == 30 || myString == "Pito") {
        println("El valor es 30")
        println("El valor es 'Pito'")
    } else {
        println("el valor no es 40 ni 30")
    }

    // todo lista
    val myList = listOf<String>("nombre", "apellido"); //! Lista de tipo imutable
    val myListMutable = mutableListOf("Escocia", "Mongolia", "Estonia");


    //TODO Sets
    //? Los Sets no admiten duplicados

    val mySet = setOf("Escocia", "Mongolia", "Estonia");


    //    TODO MAPS
    val myMap = mutableMapOf("Neo" to 20);
//    myMap.put("Brayan" to 20);
    myMap["Brayan"] = 20;
    println(myMap["Neo"]);

//    TODO BUCLES

    for (value in myList) {
        println(value)
    }
    var myCounter = 0
    while (myCounter < myList.count()) {
        println(myList[myCounter])
        myCounter++;
    }

//    TODO Opcionales
    var myOpcitional: String? = null
    //Al tipo de dato hay que ponerle eso "?" pa que sepa que puede llegar a ser nulo
        println(myOpcitional)
    myOpcitional = "no me gusta esta mierda"
        println(myOpcitional)

//TODO INVOCACACION DE METODOS
    myFunction()

    var myClass = MyClass("Neo", 20);
    print(myClass.age)


    // * ======================================= *
println("");
println("===============");
println("> PAGINA KOTLIN");

    //    TODO PAGINA KOTLIN EJ

    // Complete el código para hacer que el programa imprima "María tiene 20 años" en la salida estándar:
    val name = "Mary"
    val age = 20
    // Write your code here
    println("$name tiene $age años");
    //! Cadenas interpoladas: Kotlin permite incluir valores de variables directamente
    // dentro de una cadena de texto utilizando el signo $. En este caso, "$name tiene $age años"
    // genera una cadena en la que $name se reemplaza por el valor "Mary" y $age por el valor 20.

    val name2: String = "Neo";
    println(name2 + " :)") //? metodo concatenando

    // Read only list
    val readOnlyShapes = listOf("triangle", "square", "circle")
    println(readOnlyShapes)
// [triangle, square, circle]

// Mutable list with explicit type declaration
    val shapes: MutableList<String> = mutableListOf("triangle", "square", "circle")
    println(shapes)
// [triangle, square, circle]


}


//    TODO FUNCIONES

fun myFunction(){
    print("Esto es una funcion")
}

//TODO CLASS
class MyClass(val name:String, val age: Int){


}