package com.example.tarea_recyclerview.HerramientasRV

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.tarea_recyclerview.Bloque
import com.example.tarea_recyclerview.R

class BloqueAdapter(private val bloqueList:List<Bloque>) : RecyclerView.Adapter<BloqueViewholder>() {
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): BloqueViewholder {
        val layoutInflater = LayoutInflater.from(parent.context)
        return BloqueViewholder(layoutInflater.inflate(R.layout.item_bloque, parent, false))
    }

    override fun onBindViewHolder(holder: BloqueViewholder, position: Int) {
        val item = bloqueList[position]
        holder.render(item)
    }

    override fun getItemCount(): Int {
        return bloqueList.size
    }
}