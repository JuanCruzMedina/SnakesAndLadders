namespace SnakesAndLadders.Contracts
{
    /// <summary>
    /// Interfaz de un juego de mesa.
    /// </summary>
    public interface IBoardGame
    {
        /// <summary>
        /// Obtiene la posición de inicio en el tablero.
        /// </summary>
        /// <returns>Devuelve el número de la posición de inicio en el tablero.</returns>
        public int GetStartPosition();

        /// <summary>
        /// Obtiene la posición final del tablero.
        /// </summary>
        /// <returns>Devuelve el número de la posición final del tablero.</returns>
        public int GetEndPosition();
        
        /// <summary>
        /// Permite crear una ficha para un jugador.
        /// </summary>
        /// <returns>Retorna una nueva ficha.</returns>
        public IToken CreateToken();

        /// <summary>
        /// Permite obtener el dado utilizado para jugar.
        /// </summary>
        /// <returns>Retorna un dado.</returns>
        public IDice GetDice();
    }
}
