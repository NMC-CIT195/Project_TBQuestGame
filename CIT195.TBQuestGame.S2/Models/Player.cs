﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT195.TBQuestGame
{
    /// <summary>
    /// Player class, inherites from Character class
    /// </summary>
    public class Player : Character
    {
        #region ENUMERABLES

        #endregion

        #region FIELDS

        private int _lives;
        
        #endregion

        #region PROPERTIES
        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }

        
        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// instantiate a player and set intial properties
        /// </summary>
        /// <param name="name">player name</param>
        /// <param name="gender">player gender</param>
        /// <param name="race">player race</param>
        /// <param name="currentRoomNumber">room location as an index of the hall array</param>
        public Player(
            string name,
            GenderType gender,
            RaceType race,
            int currentRoomNumber)
            : base(name, gender, race, currentRoomNumber)
        {
            _lives = 1;
        }

        #endregion

        #region METHODS

        /// <summary>
        /// override method for a player who leaves the Mansion
        /// </summary>
        /// <returns>message for leaving</returns>
        public override string Leave()
        {
            string leavingMessage;
            leavingMessage = String.Format("Player {0} has left the game. The Mansion Master will decide whether to continue playing the game.", _name);

            return (leavingMessage);
        }

        #endregion
    }
}
