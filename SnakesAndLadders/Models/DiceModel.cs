using SnakesAndLadders.Contracts;

namespace SnakesAndLadders.Models
{
    /// <summary>
    /// Modelo de un dado.
    /// </summary>
    public class DiceModel : IDice
    {
        /// <summary>
        /// un número aleatorio al rodar el dado.
        /// </summary>
        private readonly Random _random;

        /// <summary>
        /// Valor mínimo del dado.
        /// </summary>
        public int MinValue { get; set; }

        /// <summary>
        /// Valor máximo del dado.
        /// </summary>
        public int MaxValue { get; set; }

        /// <summary>
        /// Permite instanciar un dado.
        /// </summary>
        /// <param name="minValue">Valor mínimo del dado. Por defecto es 1.</param>
        /// <param name="maxValue">Valor máximo del dado. Por defecto es 6.</param>
        public DiceModel(int minValue = 1, int maxValue = 6)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            _random = new();
        }
        public virtual int Roll() => _random.Next(1, 6);
    }
}
