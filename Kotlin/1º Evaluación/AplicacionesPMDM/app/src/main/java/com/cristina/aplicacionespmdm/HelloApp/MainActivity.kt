package com.cristina.aplicacionespmdm.HelloApp

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import com.cristina.aplicacionespmdm.R


class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        //creamos una variable y le indicamos que su valor será un objeto que buscará la view que le indiquemos por su id
        var btnSend = findViewById<Button>(R.id.botonSendMain)
        var textName = findViewById<EditText>(R.id.etName)

        btnSend.setOnClickListener {
            var name = textName.text.toString()
            if (name.isNotEmpty()) {
                // creamos un objeto tipo intetn, le decimos donde se crea y dónde actua
                var textIntent = Intent(this, SecondActivity::class.java)

                //El intent funciona como un mapa, es dinámico y necesita un nombre (key) para un valor (value). Igual que los mapas
                textIntent.putExtra("extraName", name )

                //cuando le indicamos todos los pasos, se inicia la actividad
                startActivity(textIntent)
            }
        }

    }

}

