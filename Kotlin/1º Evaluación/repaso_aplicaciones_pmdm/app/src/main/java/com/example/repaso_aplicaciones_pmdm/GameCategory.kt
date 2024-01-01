package com.example.repaso_aplicaciones_pmdm

sealed class GameCategory(var isSelected:Boolean = true) {
    object Deckbuilding : GameCategory()
    object Euro : GameCategory()
    object LCG : GameCategory()
    object Cooperative : GameCategory()
    object Legacy : GameCategory()
}
