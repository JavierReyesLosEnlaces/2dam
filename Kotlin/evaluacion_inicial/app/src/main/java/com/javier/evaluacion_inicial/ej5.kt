package com.javier.evaluacion_inicial

import kotlin.random.Random

//Programa que genere un nº aleatorio entre 0 y 500 e informe del intervalo en el que se encuentra dicho nº, entre los siguientes:
//[0,100), [100,200), [200,300), [300,400), [400,500].

fun main(){
    val num: Int = Random.nextInt(0,500)

    println("Número -> $num")

    if (num in 0..100) println("Intervalo -> 0,100")
    else if (num in 100..200) println("Intervalo -> 100,200")
    else if (num in 200..300) println("Intervalo -> 200,300")
    else if (num in 300..400) println("Intervalo -> 300,400")
    else if (num in 400..500) println("Intervalo -> 400,500")
}