using PokemonReviewApi.Models;

namespace PokemonReviewApi.Interfaces
{
    public interface IPokemonReposistory
    {
        ICollection<Pokemon> GetPokemons();
    }
}
