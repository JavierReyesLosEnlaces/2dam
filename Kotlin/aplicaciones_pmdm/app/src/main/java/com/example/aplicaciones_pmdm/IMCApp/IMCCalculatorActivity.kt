package com.example.aplicaciones_pmdm.IMCApp

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import com.example.aplicaciones_pmdm.MenuActivity
import com.example.aplicaciones_pmdm.R

class IMCCalculatorActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_imccalculator)

        //BOTÓN VOLVER
        var btnVol= findViewById<Button>(R.id.btnVolverAlMenu)
        btnVol.setOnClickListener{volverMenu()}
    }


    private fun volverMenu(){
        val intent = Intent(this, MenuActivity::class.java)
        startActivity(intent)
    }
}