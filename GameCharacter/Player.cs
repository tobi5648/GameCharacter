using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacter
{
    /// <summary>
    /// The player of the game
    /// </summary>
    public class Player : Character
    {
        //  The variables in the class
        #region Variables
       
        //  The fields in the class
        #region Fields

        /// <summary>
        /// This is how long the current game session has lasted
        /// </summary>
        protected TimeSpan gameTime;
        
        #endregion

        //  The properties in the class
        #region Properties

        /// <summary>
        /// Gets or sets how long the current game session has lasted
        /// </summary>
        public TimeSpan GameTime
        {
            get
            {
                return gameTime;
            }

            set
            {
                gameTime = value;
            }
        }

        #endregion 

        #endregion

        //  The constructors in the class
        #region Constructors

        /// <summary>
        /// The constructor of the class Player
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name=""></param>
        public Player(string name, byte level, TimeSpan gameTime) : base(name, level)
        {
            GameTime = gameTime;
        }

        #endregion
    }
}
