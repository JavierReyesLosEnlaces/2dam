package com.example.aplicaciones_pmdm.SuperoheroApp

import com.google.gson.annotations.SerializedName
// a través de una interfaz y definiendo un arbol de clases cogiendo los datos del json que nos interesen
data class SuperHeroDataResponse( // para obtener datos hay que coger los datos con exactamente el nombre
    @SerializedName("response") val response: String, //el dato del indice response lo vas a almacenar en la variable "response" -> si es un array de objetos vamos a tener que definir cada objetos por separado
    @SerializedName("results") val superheroes: List<SuperheroItemResponse  > //el results para mi lo voy a llamar superheroes
)

data class SuperheroItemResponse(
    @SerializedName("id") val superheroId: String,
    @SerializedName("name") val name: String,
    @SerializedName("image") val superheroImage:SuperheroImageResponse // es :image, por lo tanto es un objeto -> inventamos la clase SuperheroImageResponse para representarla
)
data class SuperheroImageResponse(@SerializedName("url") val url:String)
