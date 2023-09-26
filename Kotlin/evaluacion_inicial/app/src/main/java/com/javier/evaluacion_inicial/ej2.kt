package com.javier.evaluacion_inicial

import java.lang.Math.PI

//Hacer una programa con una función que calcule la longitud de la circunferencia y el área del círculo a partir de su radio.

fun main(){
    var radio: Int = 3;
    println("Radio = $radio")
    println("Longitud de la circunferencia: "+calcularLongitud(radio))
    println("Área del círculo: "+calcularLongitud(radio))
}

fun calcularLongitud(radio: Int ): Double{
    var diametro: Int = radio*2;
    return (diametro * PI);
}

fun calcularArea(radio: Int): Double{
    return(radio*radio* PI)
}