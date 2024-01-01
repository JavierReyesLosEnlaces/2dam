package com.example.app_mensajeria

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        var btnSend = findViewById<Button>(R.id.btnSend)
        var etIntroduce = findViewById<EditText>(R.id.etIntroduce)

        btnSend.setOnClickListener {
            var textIntent = Intent(this, SecondActivity::class.java)
            var nombre = etIntroduce.text.toString()
            textIntent.putExtra("nombre", nombre)
            startActivity(textIntent)
        }
    }
}