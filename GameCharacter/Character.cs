using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacter
{
    /// <summary>
    /// The character of the game
    /// </summary>
    public class Character
    {
        #region Variables
       
        #region Fields

        /// <summary>
        /// The name of the character
        /// </summary>
        protected string name;

        /// <summary>
        /// The level of the character
        /// </summary>
        protected byte level;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name of the character
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException();
                name = value;
            }
        }

        /// <summary>
        /// Gets or sets the level of the character
        /// </summary>
        public byte Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        #endregion 

        #endregion

        #region Constructors

        public Character(string name, byte level)
        {
            Name = name;
            Level = level;
        }

        #endregion

    }
}
