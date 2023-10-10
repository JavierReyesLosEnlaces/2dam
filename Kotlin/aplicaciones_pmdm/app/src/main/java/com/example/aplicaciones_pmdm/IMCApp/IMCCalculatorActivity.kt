package com.example.aplicaciones_pmdm.IMCApp

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import androidx.cardview.widget.CardView
import com.example.aplicaciones_pmdm.MenuActivity
import com.example.aplicaciones_pmdm.R

class IMCCalculatorActivity : AppCompatActivity() {

    private var isMaleSelected: Boolean = false;
    private var isFemaleSelected: Boolean = false;


    //leclaramos estas variables fuera del onCreate para que sean globales
    //globales -> accesibles desde cualquier parte de IMCCalculatorActivity

    private lateinit var  viewMale: CardView
    private lateinit var  viewFemale: CardView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_imccalculator)
        initComponents()
        initListeners()
    }

    private fun initListeners() {
        //para poner varias líneas de código metemos llaves, no paréntesis

        viewMale.setOnClickListener{
            setComponentColorMale();
        }

        viewFemale.setOnClickListener{
            setComponentColorFemale();
        }
    }

    private fun setComponentColorMale() {
        //esta función comprueba si el cardview del nombre está seleccionado
        if(!isMaleSelected){
            viewMale.setBackgroundColor(getColor(R.color.background_component_selected))
            viewFemale.setBackgroundColor(getColor(R.color.background_component))
            isMaleSelected = true
            isFemaleSelected = false
        }
    }

    private fun setComponentColorFemale() {
        TODO("Not yet implemented")
    }

    //las funciones fuera del onCreate para que esta actividad sea global
    //pero SOLO en esta actividad

    private fun initComponents(){
        viewMale = findViewById(R.id.viewMale)
        viewFemale = findViewById(R.id.viewFemale)
    }
}