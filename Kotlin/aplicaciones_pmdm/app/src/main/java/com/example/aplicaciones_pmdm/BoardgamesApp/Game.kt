package com.example.aplicaciones_pmdm.BoardgamesApp


data class Game (val name:String, val category: GameCategory, var isSelected:Boolean = false)