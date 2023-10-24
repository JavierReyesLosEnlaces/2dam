package com.example.aplicaciones_pmdm.BoardgamesApp

sealed class GameCategory(var isSelected:Boolean = true) {
    object Deckbuilding : GameCategory() //cada uno de estos objetos va a tener un atributo isSelected. Como le hemos puesto un valor por defecto true, cuando se inicie estarán todos a true
    object Euro : GameCategory()
    object LCG : GameCategory()
    object Cooperative : GameCategory()
    object Legacy : GameCategory()
}
