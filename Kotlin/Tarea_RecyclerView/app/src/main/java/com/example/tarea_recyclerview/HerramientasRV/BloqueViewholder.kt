package com.example.tarea_recyclerview.HerramientasRV

import android.view.View
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.example.tarea_recyclerview.Bloque
import com.example.tarea_recyclerview.R

class BloqueViewholder (view:View):RecyclerView.ViewHolder(view){

    val bloqueTexto = view.findViewById<TextView>(R.id.tvBloqueTexto)
    fun render(bloq:Bloque){
        bloqueTexto.text=bloq.nombre
    }
}