package com.example.repaso_aplicaciones_pmdm

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        var btnHelloApp = findViewById<Button>(R.id.btnHelloApp)
        btnHelloApp.setOnClickListener { navigateToHelloApp() }

        var btnMessageApp = findViewById<Button>(R.id.btnMessageApp)
        btnHelloApp.setOnClickListener { navigateToMessageApp() }

        var btnIMCApp = findViewById<Button>(R.id.btnIMCApp)
        btnHelloApp.setOnClickListener { navigateToIMCApp() }

        var btnBoardgamesApp = findViewById<Button>(R.id.btnBoardgamesApp)
        btnBoardgamesApp.setOnClickListener{ navigateToBoardgamesApp() }
    }

    private fun navigateToIMCApp() {
        var textIntent = Intent(this, IMCactivity::class.java )
        startActivity(textIntent)
    }

    private fun navigateToMessageApp() {
        var textIntent = Intent(this, MessageActivity::class.java )
        startActivity(textIntent)
    }

    private fun navigateToHelloApp() {
        var textIntent = Intent(this, NameActivity::class.java )
        startActivity(textIntent)
    }
    private fun navigateToBoardgamesApp(){
        var intent = Intent(this, BoardgamesActivity::class.java)
        startActivity(intent)
    }

}