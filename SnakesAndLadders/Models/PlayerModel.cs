using SnakesAndLadders.Contracts;

namespace SnakesAndLadders.Models
{
    /// <summary>
    /// Modelo de un jugador.
    /// </summary>
    public class PlayerModel: IPlayer 
    {
        /// <summary>
        /// Instancia un jugador.
        /// </summary>
        /// <param name="name">Nombre del jugador.</param>
        public PlayerModel(IBoardGame game)
        {
            Game = game;
            Token = game.CreateToken();
        }
        
        /// <summary>
        /// Ficha del jugador.
        /// </summary>
        private IToken Token { get; set; }
        
        /// <summary>
        /// Juego en el que participa.
        /// </summary>
        private IBoardGame Game { get; set; }

        /// <summary>
        /// Espacios que debe moverse la ficha del jugador.
        /// </summary>
        private int SpacesToMove { get; set; }

        #region Querys
        
        public int GetTokenPosition() => Token.GetPosition();
        public int GetSpacesToMove() => SpacesToMove;
        public bool Won() => Token.GetPosition() == Game.GetEndPosition();

        #endregion

        #region Commands

        public void RollTheDie()
        {
            SpacesToMove = Game.GetDice().Roll();
        }

        public void Move()
        {
            if (SpacesToMove != 0)
            {
                MoveToken(SpacesToMove);
                SpacesToMove = 0;
            }
        }

        public void MoveToken(int spaces)
        {
            if ((Token.GetPosition() + spaces) < Game.GetStartPosition()) throw new InvalidOperationException("Invalid movement.");
            if ((Token.GetPosition() + spaces) > Game.GetEndPosition()) return;
            Token.Move(spaces);
        }

        public IBoardGame GetBoardGame() => Game;

        #endregion
    }
}
