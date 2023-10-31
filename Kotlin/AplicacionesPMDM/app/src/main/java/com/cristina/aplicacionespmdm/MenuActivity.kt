package com.cristina.aplicacionespmdm

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import com.cristina.aplicacionespmdm.BoardGamesApp.BoardGamesActivity
import com.cristina.aplicacionespmdm.HelloApp.MainActivity
import com.cristina.aplicacionespmdm.IMC_App.IMCCalculator
import com.cristina.aplicacionespmdm.MessageApp.MessageActivity

class MenuActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_menu)

        var btnHelloApp = findViewById<Button>(R.id.btnHelloApp)
        btnHelloApp.setOnClickListener{navigateToHelloApp()}

        var btnMessageApp = findViewById<Button>(R.id.btnMessageApp)
        btnMessageApp.setOnClickListener{navigateToMessageApp()}

        var btnIMCApp = findViewById<Button>(R.id.btnIMC)
        btnIMCApp.setOnClickListener{navigateToIMCAppp()}

        var btnBoardgamesApp = findViewById<Button>(R.id.btnBoardgamesApp)
        btnBoardgamesApp.setOnClickListener{ navigateToBoardgamesApp() }


    }

    private fun navigateToBoardgamesApp(){
        var intent = Intent(this, BoardGamesActivity::class.java)
        startActivity(intent)
    }

    private fun navigateToHelloApp(){
        var intent = Intent(this, MainActivity::class.java)
        startActivity(intent)
    }

    private fun navigateToMessageApp(){
        var intent = Intent(this, MessageActivity::class.java)
        startActivity(intent)
    }

    private fun navigateToIMCAppp(){
        var intent = Intent(this, IMCCalculator::class.java)
        startActivity(intent)
    }


}