package com.example.aplicaciones_pmdm.SuperoheroApp

import retrofit2.Response
import retrofit2.http.GET
import retrofit2.http.Path

// interfaz es la plantilla donde defines las funciones de acceso a esa API
// corrutinas: funciones especiales: para abrir procesos en hilos
interface ApiService {
    @GET("/api/10229233666327556/search/{name}") //en esta API en particular la búsqueda va así
    suspend fun getSuperheroes(@Path("name") superheroName:String): Response<SuperHeroDataResponse>
    // todas las funciones que se vayan a ejecutar en corrutinas deben tener un suspend delante
    // vamos a crear una clase por cada objeto del json
    // importamos la de retrofit2

    /*
    @GET("/api/10229233666327556/{id}")
    suspend fun getSuperheroDetail(@Path("id") superheroId:String):Response<SuperHeroDetailResponse>
    */
}