package com.example.tarea_recyclerview_dialog
import android.graphics.Color
import android.view.View
import android.widget.TextView
import androidx.cardview.widget.CardView
import androidx.recyclerview.widget.RecyclerView
// En el ViewHolder declaramos los elementos del layout
class VerticalBarViewHolder(view:View) : RecyclerView.ViewHolder(view) //le pasas un view -> layout vb_items.xml
{
    private val tvH: TextView = view.findViewById(R.id.tvH)
    private val cardViewContainer: CardView = view.findViewById(R.id.cardViewContainer)
    // La función "render" pinta cada uno de los elementos de la lista según los atributos de cada objeto definidos en la lista
    fun render (verticalBarList: VerticalBar)
    {
        when (verticalBarList.name){
            "V1(20%)" -> {
                tvH.text = verticalBarList.name
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
                // setCardBackgroundColor necesita que le pases un int
            }
            "V2(35%)" -> {
                tvH.text = verticalBarList.name
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
            }
            "V3(50%)" -> {
                tvH.text = verticalBarList.name
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
            }
            "V4(65%)" -> {
                tvH.text = verticalBarList.name
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
            }
            "V5(80%)" -> {
                tvH.text = verticalBarList.name
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
            }
        }
        /*when(verticalBarList.color){
            Color.argb(20,200,255,100) -> {
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
            }
            Color.argb(35,2,2,2) -> {
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
            }
            Color.argb(50,2,2,2) -> {
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
            }
            Color.argb(65,2,2,2) -> {
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
            }
            Color.argb(80,2,2,2) -> {
                cardViewContainer.setCardBackgroundColor(verticalBarList.color)
            }
        }*/
    }
}
