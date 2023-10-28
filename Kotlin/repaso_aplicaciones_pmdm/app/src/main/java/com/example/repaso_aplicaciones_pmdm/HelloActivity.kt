package com.example.repaso_aplicaciones_pmdm

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView

class HelloActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_hello)

        var helloText = findViewById<TextView>(R.id.helloText);
        var nombre: String = intent.extras?.getString("clave").orEmpty()
        // recoge valor de extra bajo la clave y hacemos que sea el texto del textview
        helloText.text="Hola "+nombre+"!";
    }
}