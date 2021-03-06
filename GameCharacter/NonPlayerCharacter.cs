﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacter
{
    /// <summary>
    /// The npc of the game
    /// </summary>
    public class NonPlayerCharacter : Character
    {
        //  The fields in the class
        #region Fields

        /// <summary>
        /// This is to see if the npc has been activated
        /// </summary>
        private bool isActive;
        
        #endregion

        //  The properties to the fields in the class
        #region Properties

        /// <summary>
        /// Gets or sets the isActive of the npc
        /// </summary>
        protected bool IsActive
        {
            get
            {
                return isActive;
            }

            set
            {
                isActive = value;
            }
        }

        #endregion

        //  The constructors in the class
        #region Constructors

        /// <summary>
        /// The constructor of the class NonPlayerCharacter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name=""></param>
        public NonPlayerCharacter(string name, byte level, bool isActive) : base(name, level)
        {
            IsActive = isActive;
        }

        #endregion
    }
}
