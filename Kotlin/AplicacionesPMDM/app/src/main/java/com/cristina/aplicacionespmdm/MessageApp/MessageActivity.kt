package com.cristina.aplicacionespmdm.MessageApp

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import com.cristina.aplicacionespmdm.R

class MessageActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_message)


        //creamos una variable y le indicamos que su valor será un objeto que buscará la view que le indiquemos por su id

        var btnSend = findViewById<Button>(R.id.botonSend)
        var textName = findViewById<EditText>(R.id.mensgSend)

        btnSend.setOnClickListener {

            var name = textName.text.toString()
            if (name.isNotEmpty()) {
                var textIntent = Intent(this, secondMesasge::class.java)
                textIntent.putExtra("extraName", name )
                startActivity(textIntent)
            }
        }

        var textMessageBack = findViewById<TextView>(R.id.textoSuperior)
        var recievedBack: String = intent.extras?.getString("extraName").orEmpty()

        textMessageBack.text= recievedBack


    }

}
