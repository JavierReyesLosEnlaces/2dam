package com.example.recyclerviewexample

class SuperheroProvider {
    companion object{  //necesario para poder acceder a el listado desde main
        val superHeroList = listOf<Superhero>(
            Superhero(
                "superman",
                "dc",
                "clark kent",
                "https://phantom-elmundo.unidadeditorial.es/ceb5ddfd91bd7ea95edd24ad7a228ce7/resize/1200/f/jpg/assets/multimedia/imagenes/2022/08/03/16595421832009.jpg"
            ),
            Superhero(
                "batman",
                "dc",
                "bruce wayne",
                "https://www.google.com/url?sa=i&url=https%3A%2F%2Fes.wikipedia.org%2Fwiki%2FBatman&psig=AOvVaw3MgI3e6m5UtgAoXrHcBmRY&ust=1699726251213000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCJiisu2DuoIDFQAAAAAdAAAAABAK"
            ),
            Superhero(
                "spiderman",
                "marvel",
                "peter parker",
                "https://www.google.com/url?sa=i&url=https%3A%2F%2Fes.wikipedia.org%2Fwiki%2FSpider-Man&psig=AOvVaw0wgNiLmDBvyFutz_z0sqvJ&ust=1699726271850000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIj_2_aDuoIDFQAAAAAdAAAAABAE"
            ),
            Superhero(
                "wonder woman",
                "dc",
                "diana prince",
                "https://www.google.com/url?sa=i&url=https%3A%2F%2Fokdiario.com%2Fseries%2Fwonder-woman-television-2572876&psig=AOvVaw0CW-wGHQnVkJuwM5AsxirO&ust=1699726294677000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCICH1YGEuoIDFQAAAAAdAAAAABAE"
            ),
            Superhero(
                "iron man",
                "marvel",
                "tony stark",
                "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.fotogramas.es%2Fnoticias-cine%2Fa29435311%2Fvengadores-endgame-iron-man-vivo-en-la-nube%2F&psig=AOvVaw0nS73AFvXQp6XmqwI9WBt-&ust=1699726313172000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCLi2soqEuoIDFQAAAAAdAAAAABAE"
            ),
            Superhero(
                "black widow",
                "marvel",
                "natasha romanoff",
                "URL_de_la_imagen"
            ),
            Superhero(
                "captain america",
                "marvel",
                "steve rogers",
                "URL_de_la_imagen"
            ),
            Superhero(
                "thor",
                "marvel",
                "thor odinson",
                "URL_de_la_imagen"
            ),
            Superhero(
                "flash",
                "dc",
                "barry allen",
                "URL_de_la_imagen"
            ),
            Superhero(
                "green lantern",
                "dc",
                "hal jordan",
                "URL_de_la_imagen"
            )
        )
    }
}