package com.sergio.room_database.data.database

import androidx.room.Database
import androidx.room.RoomDatabase
import com.sergio.room_database.data.database.dao.QuoteDao
import com.sergio.room_database.data.database.entities.QuoteEntity

@Database(entities = [QuoteEntity::class], version = 1)
abstract class QuoteDatabase: RoomDatabase() {

    abstract fun getQuoteDao(): QuoteDao
}
