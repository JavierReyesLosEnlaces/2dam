package com.example.aplicaciones_pmdm

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import com.example.aplicaciones_pmdm.HelloApp.MainActivity
import com.example.aplicaciones_pmdm.IMCApp.IMCCalculatorActivity
import com.example.aplicaciones_pmdm.MessageApp.MessageActivity
import com.example.aplicaciones_pmdm.SuperoheroApp.SuperheroListActivity

class MenuActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_menu)

        //HELLOAPP
        var btnHelloApp = findViewById<Button>(R.id.btnHelloApp);
        btnHelloApp.setOnClickListener{navigateToHelloApp()}

        //MESSAGE_ACTIVITY
        var btnMessageApp = findViewById<Button>(R.id.btnMessageActivity);
        btnMessageApp.setOnClickListener{navigateToMessageActivity()}

        //IMC ACTIVITY
        var btnIMCApp = findViewById<Button>(R.id.btnIMCActivity);
        btnIMCApp.setOnClickListener{navigateToIMCActivity()}

        //Superhero ACTIVITY
        var btnSuperheroApp = findViewById<Button>(R.id.btnSuperheroActivity);
        btnSuperheroApp.setOnClickListener{navigateToSuperheroActivity()}
    }

    private fun navigateToHelloApp() {
        val intent = Intent(this, MainActivity::class.java)
        startActivity(intent)
    }

    private fun navigateToMessageActivity() {
        val intent = Intent(this, MessageActivity::class.java)
        startActivity(intent)
    }

    private fun navigateToIMCActivity() {
        val intent = Intent(this, IMCCalculatorActivity::class.java)
        startActivity(intent)
    }

    private fun navigateToSuperheroActivity() {
        val intent = Intent(this, SuperheroListActivity::class.java)
        startActivity(intent)
    }
}