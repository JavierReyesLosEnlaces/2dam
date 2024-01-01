package com.javier.evaluacion_inicial

//Hacer una programa que a partir de un valor contenido en una variable entera solicitada por consola, cuyo valor debe estar entre 1 y 7, muestre el nombre del día de la semana correspondiente (lunes=1, martes=2  …)
//También otra versión que indique si el nº corresponde a un día laborable o a un festivo.

fun main(){
    var v: Int
    do{
        println("Introduce un número del 1 al 7: ")
        v = readLine()?.toInt() as Int;

        if(v in 1..7){
            when (v){
                1 -> println("Lunes")
                2 -> println("Martes")
                3 -> println("Miércoles")
                4 -> println("Jueves")
                5 -> println("Viernes")
                6 -> println("Sábado")
                7 -> println("Domingo")
            }
            if (v in (1..5)){
                println("Es un día laborable")
            }else if (v in (6..7)){
                println("Es día festivo")
            }
        }
    }while (v !in (1..7))

}