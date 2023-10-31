package com.cristina.aplicacionespmdm.HelloApp

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView
import com.cristina.aplicacionespmdm.R

class SecondActivity : AppCompatActivity() {

    // esto es una segunda actividad que vamos a comunicar con nuestro mainActivity
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_second)

        var textHola = findViewById<TextView>(R.id.helloText)
        var nombre: String = intent.extras?.getString("extraName").orEmpty()

        textHola.text= "Hola $nombre"

    }
}