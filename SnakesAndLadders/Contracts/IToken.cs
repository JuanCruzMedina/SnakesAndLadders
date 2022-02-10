namespace SnakesAndLadders.Contracts
{
    /// <summary>
    /// Interfaz de una ficha.
    /// </summary>
    public interface IToken
    {
        /// <summary>
        /// Obtiene la posición de la ficha en el tablero.
        /// </summary>
        /// <returns>Posición de la ficha.</returns>
        public int GetPosition();
        
        /// <summary>
        /// Mueve la ficha.
        /// </summary>
        /// <param name="spaces">Cantidad de espacios por moverse.</param>
        public void Move(int spaces);
    }
}
