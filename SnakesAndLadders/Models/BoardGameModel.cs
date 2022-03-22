
using SnakesAndLadders.Contracts;

namespace SnakesAndLadders.Models
{
    /// <summary>
    /// Modelo de un juego de mesa.
    /// </summary>
    public class BoardGameModel : IBoardGame
    {
        /// <summary>
        /// Instancia un juego de mesa.
        /// </summary>
        /// <param name="dice">Dado a utilizar en el juego.</param>
        /// <param name="startPosition">Posición inicial del tablero. Por defecto es 1.</param>
        /// <param name="endPosition">Posición final del tablero. Por defecto es 100.</param>
        /// <exception cref="ArgumentNullException">Excepción arrojada si el dado es nulo.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Excepción arrojada si el rango que va desde la posición inicial y la posición final del tablero es inválido.</exception>
        public BoardGameModel(IDice dice, int startPosition = 1, int endPosition = 100)
        {
            Dice = dice ?? throw new ArgumentNullException(nameof(dice));
            if (startPosition >= endPosition) throw new ArgumentOutOfRangeException($"Invalid range of positions. ({startPosition}-{endPosition})");
            StartPosition = startPosition;
            EndPosition = endPosition;
        }

        /// <summary>
        /// Dado utilizado en el juego de mesa.
        /// </summary>
        private readonly IDice Dice;
        
        /// <summary>
        /// Posición de inicio en el tablero.
        /// </summary>
        private int StartPosition { get; }

        /// <summary>
        /// Posición final en el tablero.
        /// </summary>
        private int EndPosition { get; }

        public int GetStartPosition() => StartPosition;
        public int GetEndPosition() => EndPosition;
        public IDice GetDice() => Dice;
        public IToken CreateToken() => new TokenModel(StartPosition);
    }
}

