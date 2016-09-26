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
        //  The variables used in the class
        #region Variables
       
        //  The fields used in the class
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

        //  The properties to the fields in the class
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

        //  The constructors in the class
        #region Constructors

        /// <summary>
        /// The constructor of the class Character
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        public Character(string name, byte level)
        {
            Name = name;
            Level = level;
        }

        #endregion

    }
}
