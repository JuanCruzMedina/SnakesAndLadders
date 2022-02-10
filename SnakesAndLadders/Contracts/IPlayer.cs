namespace SnakesAndLadders.Contracts
{
    /// <summary>
    /// Interfaz de un jugador.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Permite rodar un dado.
        /// </summary>
        public void RollTheDie();

        /// <summary>
        /// Permite obtener la posición de la ficha.
        /// </summary>
        /// <returns></returns>
        public int GetTokenPosition();

        /// <summary>
        /// Permite determinar si el jugador gano.
        /// </summary>
        /// <returns>Devuelve verdadero si gano. Falso en caso contrario.</returns>
        public bool Won();
        
        /// <summary>
        /// Obtiene la cantidad de espacios que debe moverse la ficha en el turno.
        /// </summary>
        /// <returns>Devuelve la cantidad de espacios que debe moverse la ficha.</returns>
        public int GetSpacesToMove();

        /// <summary>
        /// Mueve la ficha del jugador en base al resultado de rodar el dado.
        /// </summary>
        public void Move();
        
        /// <summary>
        /// Mueve la ficha del jugador.
        /// </summary>
        /// <param name="spaces">Cantidad de espacios que se moverá la ficha. </param>
        public void MoveToken(int spaces);
    }
}
