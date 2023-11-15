package com.example.tarea_recyclerview_dialog

import android.view.View
import android.widget.TextView
import androidx.cardview.widget.CardView
import androidx.recyclerview.widget.RecyclerView

class VerticalBarViewHolder(view:View) : RecyclerView.ViewHolder(view) //le pasas los elementos en item
{
    private val tvH: TextView = view.findViewById(R.id.tvH)
    private val cardViewContainer: CardView = view.findViewById(R.id.cardViewContainer)
    fun render (verticalBarList: VerticalBar){
        when (verticalBarList.name){ //cuando lo del paréntesis coincida con otra cosa
            R.string.v1_20.toString() -> {
                tvH.text = "V1(20%)"
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
            }
        }
    }
}
