package com.example.tarea_recyclerview_dialog

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView

class VerticalBarAdapter (val verticalBarList: List<VerticalBar>):
    RecyclerView.Adapter<VerticalBarViewHolder>(){
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): VerticalBarViewHolder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.vb_item, parent, false)
        return VerticalBarViewHolder(view)
    }

    override fun onBindViewHolder(holder: VerticalBarViewHolder, position: Int) {
        holder.render(verticalBarList[position])
    }

    override fun getItemCount(): Int = verticalBarList.size


}