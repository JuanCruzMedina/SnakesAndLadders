using SnakesAndLadders.Contracts;

namespace SnakesAndLadders.Models
{
    /// <summary>
    /// Modelo de una ficha.
    /// </summary>
    public class TokenModel : IToken
    {
        /// <summary>
        /// Instancia una ficha.
        /// </summary>
        /// <param name="position">Posición en la cual se encuentra la ficha.</param>
        public TokenModel(int position)
        {
            Position = position;
        }

        /// <summary>
        /// Posición de la ficha.
        /// </summary>
        private int Position { get; set; }

        public int GetPosition() => Position;
        public void Move(int spaces) => Position += spaces;
    }
}
