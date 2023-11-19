package com.example.tarea_recyclerview_dialog

import android.graphics.Color
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView

//arriba declaras las variables
//una variable que guarda la lista de barras verticales

class MainActivity : AppCompatActivity() {
    private lateinit var rvVerticalColors: RecyclerView
    private lateinit var adapterVerticalBar: VerticalBarAdapter
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        initComponents()
    }

    private fun initComponents() {
        rvVerticalColors = findViewById(R.id.rvVerticalColors)
        adapterVerticalBar = VerticalBarAdapter(verticalBarList)
        rvVerticalColors.layoutManager = LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false)
        rvVerticalColors.adapter = adapterVerticalBar
    }

    private val verticalBarList = mutableListOf(
        VerticalBar("vb1",  Color.argb(20,200,255,100)),
        VerticalBar("vb2",  Color.argb(35,2,2,2)),
        VerticalBar("vb3",  Color.argb(50,2,2,2)),
        VerticalBar("vb4",  Color.argb(65,2,2,2)),
        VerticalBar("vb5",  Color.argb(80,2,2,2)),
    )
        // si accedes a una data class esta lista es mutable
        // si accedes a una sealed class (clase con valores que no pueden cambiar) esta lista es inmutable
}