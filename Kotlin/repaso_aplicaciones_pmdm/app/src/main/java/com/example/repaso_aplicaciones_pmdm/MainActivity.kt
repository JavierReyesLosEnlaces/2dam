package com.example.repaso_aplicaciones_pmdm

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.EditText

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        //creamos una variable edit text
        var et_Principal = findViewById<EditText>(R.id.et_Principal);

        //creamos la variable botón buscando por id
        var btn_Send = findViewById<Button>(R.id.btn_Send);
        btn_Send.setOnClickListener{
            // se recoge el nombre
            var nombre = et_Principal.text.toString();
            // si nombre no está vacio, nos movemos al HelloActivity
            if (!nombre.isEmpty()){
                var textIntent = Intent(this, HelloActivity::class.java);
                textIntent.putExtra("clave",nombre) //añade una variable bajo una clave
                startActivity(textIntent);
            }
        }
    }
}