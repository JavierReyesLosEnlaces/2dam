package com.cristina.aplicacionespmdm.BoardGamesApp

sealed class GameCategory (var isSelected:Boolean = true) {
    object Deckbuilding : GameCategory()
    object Euro : GameCategory()
    object LCG : GameCategory()
    object Cooperative : GameCategory()
    object Legacy : GameCategory()

}

// clase inmutable: no puedes meter más