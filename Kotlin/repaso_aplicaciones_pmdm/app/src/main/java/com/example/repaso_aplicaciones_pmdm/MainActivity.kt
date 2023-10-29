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
    }

    private fun navigateToHelloApp() {
        var textIntent = Intent(this, NameActivity::class.java )
        startActivity(textIntent)
    }
}