package com.javier.evaluacion_inicial

//Programa que dado un número entero obtenga y devuelva la tabla de multiplicar de un número resolviéndolo con los 3 tipos de estructuras de control repetitivas:
// while, do…while y for.

fun main(){
    println("Introduce un número: ")
    //tabla1(readln().toInt())
    //tabla2(readln().toInt())
    tabla3(readln().toInt())

}

fun tabla1(num:Int){
    //while
    var x = 0
    while (x<=10){
        println("$num * $x = "+(num*x))
        x++
    }
}

fun tabla2(num:Int){
    //do while
    var x:Int = 0
    do{
        println("$num * $x = "+(num*x))
        x++
    }while(x<=10)
}

fun tabla3(num:Int){
    //for
    for (x in (0..10)){
        println("$num * $x = "+(num*x))
    }
}
