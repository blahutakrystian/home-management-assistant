package com.example.hma_mobile.data.repository

import kotlinx.coroutines.flow.Flow


interface TaskRepositoryInterface{
    suspend fun getUsersTasks(userId: Int): Flow<List<Task>>
}