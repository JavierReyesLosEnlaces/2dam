package com.example.app_mensajeria

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView

class SecondActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_second)

        var tvMessage2 = findViewById<TextView>(R.id.tvMessage2)
        var nombre: String = intent.extras?.getString("nombre").orEmpty()

        tvMessage2.text = nombre

    }
}