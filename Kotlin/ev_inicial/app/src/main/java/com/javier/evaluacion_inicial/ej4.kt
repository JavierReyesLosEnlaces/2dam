package com.javier.evaluacion_inicial

//Programa que dados tres datos numéricos  los muestre ordenados de menor a mayor.

fun main(){
    println("Introduce tres números para ordenarlos: ")
    ordenar(readln().toInt(), readln().toInt(), readln().toInt())
}

fun ordenar(a: Int, b: Int, c: Int){
    var lista = arrayListOf<Int>(a,b,c)
    lista.sortDescending()

    for(i in lista){
        print("$i ")
    }
}