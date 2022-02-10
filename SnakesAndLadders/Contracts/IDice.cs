namespace SnakesAndLadders.Contracts
{
    /// <summary>
    /// Interfaz de un dado.
    /// </summary>
    public interface IDice
    {
        /// <summary>
        /// Permite rodar el dado.
        /// </summary>
        /// <returns>El número obtenido al rodar el dado.</returns>
        public virtual int Roll() => 0;
    }
}
