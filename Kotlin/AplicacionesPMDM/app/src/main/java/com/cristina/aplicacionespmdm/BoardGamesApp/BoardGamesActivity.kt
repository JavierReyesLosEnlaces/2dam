package com.cristina.aplicacionespmdm.BoardGamesApp

import android.app.Dialog
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.RadioButton
import android.widget.RadioGroup

import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.cristina.aplicacionespmdm.R
import com.google.android.material.floatingactionbutton.FloatingActionButton

class BoardGamesActivity : AppCompatActivity() {

    private val categories = listOf(
        GameCategory.Cooperative,
        GameCategory.Deckbuilding,
        GameCategory.Euro,
        GameCategory.LCG,
        GameCategory.Legacy,
    )

   private val games = mutableListOf(
        Game("Frostpunk", GameCategory.Cooperative),
        Game("Arboles", GameCategory.Deckbuilding),
        Game("Mamamia", GameCategory.Euro),
        Game("Arkam", GameCategory.LCG),
        Game("Angry birb", GameCategory.Legacy),

        )

    private lateinit var categoriesAdapter: CategoriesAdapter
    private lateinit var gamesAdapter: GamesAdapter

    private lateinit var rvCategories: RecyclerView;
    private lateinit var rvGames: RecyclerView;

    private lateinit var fabAddGame: FloatingActionButton;
    override fun onCreate(savedInstanceState: Bundle?) {

        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_board_games)

        initcomponents();
        initUI();
    }

    private fun initUI() {
        categoriesAdapter = CategoriesAdapter(categories)
        rvCategories.layoutManager = LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false)
        rvCategories.adapter = categoriesAdapter


        //gamesAdapter = GamesAdapter(games, {onGameSelected(it)}) //it: pasamos todas las iteraciones de una en una
        gamesAdapter = GamesAdapter(games) {position -> onGameSelected(position)}
        rvGames.layoutManager = LinearLayoutManager(this, LinearLayoutManager.VERTICAL, false)
        rvGames.adapter = gamesAdapter

    }

    private fun initcomponents() {
        rvCategories = findViewById<RecyclerView>(R.id.rvCategories)
        rvGames = findViewById<RecyclerView>(R.id.rvGames)
        fabAddGame = findViewById(R.id.fabAddGame)
    }

    private fun initListeners() { fabAddGame.setOnClickListener{ showDialog() }
    }

    private fun showDialog() {
        val dialog = Dialog(this)
        dialog.setContentView(R.layout.dialog_game)

        val btnAddGame: Button = dialog.findViewById(R.id.btnAddGame)
        val etGame: EditText = dialog.findViewById(R.id.etGame)
        val rgCategories: RadioGroup = dialog.findViewById(R.id.rgCategories)

        btnAddGame.setOnClickListener {
            val currentGame = etGame.text.toString()
            if (currentGame.isNotEmpty()) {
                val selectedId = rgCategories.checkedRadioButtonId
                val selectedRadioButton: RadioButton = rgCategories.findViewById(selectedId)
                val currentCategory: GameCategory = when (selectedRadioButton.text) {
                    getString(R.string.dialog_cooperative_category) -> GameCategory.Cooperative
                    getString(R.string.dialog_deckbuilding_category) -> GameCategory.Deckbuilding
                    getString(R.string.dialog_euro_category) -> GameCategory.Euro
                    getString(R.string.dialog_lcg_category) -> GameCategory.LCG
                    else -> GameCategory.Legacy
                }
                games.add(Game(currentGame, currentCategory))
                updateGames()
                dialog.hide()

            }
        }
        dialog.show()

    }

    private fun updateGames(){
        gamesAdapter.notifyDataSetChanged()
        //actualiza la lista de games y notifica que ha cambiado el conjunto de datos
    }

    private fun onGameSelected(position:Int){
        games[position].isSelected = !games[position].isSelected
        updateGames()
    }
}
