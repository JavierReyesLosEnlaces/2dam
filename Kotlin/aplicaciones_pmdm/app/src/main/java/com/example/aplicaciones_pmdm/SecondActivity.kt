package com.example.aplicaciones_pmdm

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView

class SecondActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_second)

        var textoHola = findViewById<TextView>(R.id.helloText)
        var nombre: String = intent.extras?.getString("extra_name").orEmpty()
        textoHola.text = "Hola $nombre"
    }
}