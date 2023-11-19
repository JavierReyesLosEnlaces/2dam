package com.example.tarea_recyclerview_dialog

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView

class VerticalBarAdapter (val verticalBarList: List<VerticalBar>): //recibe una lista de objetos VerticalBar
    RecyclerView.Adapter<VerticalBarViewHolder>(){ //hereda de RecyclerView.Adapter<VerticalBarViewHolder>
    // toma el layout que hemos creado para los elementos del RecyclerView y se lo pasa al ViewHolder.
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): VerticalBarViewHolder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.vb_item, parent, false)
        return VerticalBarViewHolder(view)
    }

    // se encarga de ejecutar las acciones del ViewHolder sobre cada uno de los elementos de la lista
    override fun onBindViewHolder(holder: VerticalBarViewHolder, position: Int) {
        holder.render(verticalBarList[position])
    }

    // se encarga de determinar el tamaño de la lista
    override fun getItemCount(): Int = verticalBarList.size


}