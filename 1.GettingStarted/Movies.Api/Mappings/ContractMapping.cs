using Movies.Contracts.Requests;
using Movies.Application.Models;

namespace Movies.Api.Mappings
{
    public static class ContractMapping
    {
        public static Movie MapToMovie(this CreateMovieRequest request) {
           return  new Movie
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                YearOfRelease = request.YearOfRelease,
                Genres = request.Genres.ToList(),
            };

        }
    }
}
