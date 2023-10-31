package com.cristina.aplicacionespmdm.MessageApp

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import com.cristina.aplicacionespmdm.R

class secondMesasge : AppCompatActivity() {

    // esto es una segunda actividad que vamos a comunicar con nuestro mainActivity
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_second_mesasge)

        var textMessage = findViewById<TextView>(R.id.text)
        var recieved: String = intent.extras?.getString("extraName").orEmpty()

        textMessage.text= recieved


        var btnRecieved = findViewById<Button>(R.id.botonRecieved)
        var textName = findViewById<EditText>(R.id.etName)

        btnRecieved.setOnClickListener {

            var name = textName.text.toString()
            if (name.isNotEmpty()) {
                var textIntent = Intent(this, secondMesasge::class.java)
                textIntent.putExtra("extraName", name )
                startActivity(textIntent)
            }
        }

    }


}