package com.example.aplicaciones_pmdm.HelloApp

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.EditText
import com.example.aplicaciones_pmdm.R

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        var boton = findViewById<Button>(R.id.btnSend)
        var texto = findViewById<EditText>(R.id.etName)

        boton.setOnClickListener{
            //Log.i("Jav", "Javier Reyes Álvarez")
            var name = texto.text.toString();
            Log.i("Nombre del usuario ->", name)

            if (name.isNotEmpty()){
                var textIntent = Intent(this, SecondActivity::class.java)
                textIntent.putExtra("extra_name", name)

                //añadir un elemento al array extras que es un atributo
                //este array es más una lista que un array : hay un índice (cualquier cosa) y un valor asociado
                     //Clave: "extra_name"
                     // Valor: name (variable)

                //Intent tiene un atributo "Extras" en el que se pueden almacenar valores
                //Método ".putExtra() es el método para añadir extras"
                //Los intents son globales -> accesibles desde cualquier activity
                startActivity(textIntent)
            }
        }
    }
}