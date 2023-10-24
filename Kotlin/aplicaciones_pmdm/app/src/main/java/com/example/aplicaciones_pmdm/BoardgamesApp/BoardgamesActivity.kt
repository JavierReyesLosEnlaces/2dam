package com.example.aplicaciones_pmdm.BoardgamesApp

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.recyclerview.widget.RecyclerView
import com.example.aplicaciones_pmdm.R
/*
*
ADAPTER CREA PLANTILLA
	CONTAR ELEMENTOS
	CREAR PLANTILLA
	INVOCAR VIEW HOLDER
SE LA PASA LA PLANTILLA AL VIEW HOLDER
*/

class BoardgamesActivity : AppCompatActivity() {

    private lateinit var rvCategories: RecyclerView
    private lateinit var rvGames: RecyclerView

    private lateinit var categoriesAdapter: CategoriesAdapter
    private lateinit var gamesAdapter: GamesAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_boardgames)
        initComponents();
        initUI()
    }

    private fun initComponents() {
        rvCategories = findViewById<RecyclerView>(R.id.rvCategories)
        rvGames = findViewById<RecyclerView>(R.id.rvGames)
    }

    private fun initUI(){
        categoriesAdapter = CategoriesAdapter(categories)
        gamesAdapter = GamesAdapter(games)
    }

}