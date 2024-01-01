package com.javier.evaluacion_inicial

//Hacer una programa que compruebe si el contenido de una variable entera es par o impar

fun main(){
    var num: Int = 4;
    if(num%2==0){
        println("$num es un número par")
    }else{
        println("$num es un número impar")
    }
}