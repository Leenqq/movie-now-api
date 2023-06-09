﻿using MovieNowAPI.Entities;

namespace MovieNowAPI.Repository
{
    public interface IMovieRepository : IDisposable
    {
        Task<List<Movie>> GetAllMovies();
        Task<Movie> GetMovieById(int id);
        Task<List<Movie>> FilterMovies(string title, string genre, string year);
        Task<List<Movie>> GetRecentMovies();

        Task<List<RatedMovie>> GetRatedMoviesByUser(int userId);
        Task Save();
    }
}
