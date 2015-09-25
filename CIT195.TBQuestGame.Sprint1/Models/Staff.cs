﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT195.TBQuestGame.Sprint1
{
    /// <summary>
    /// Guest class, inherites from Character class
    /// </summary>
    public class Staff : Character
    {
        #region ENUMERABLES

        #endregion

        #region FIELDS

        private bool _appearsFriendly;
        private string _greeting;

        #endregion

        #region PROPERTIES

        public bool AppearsFriendly
        {
            get { return _appearsFriendly; }
            set { _appearsFriendly = value; }
        }

        public string InitialGreeting
        {
            get { return _greeting; }
            set { _greeting = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Staff()
        {

        }
        /// <summary>
        /// instantiate a guest and set intial properties
        /// </summary>
        /// <param name="name">guest name</param>
        /// <param name="gender">guest gender</param>
        /// <param name="race">guest race</param>
        /// <param name="currentRoomNumber">room location as an index of the hall array</param>
        public Staff(
            string name,
            GenderType gender,
            RaceType race,
            int currentRoomNumber)
            : base(name, gender, race, currentRoomNumber)
        {

        }

        #endregion

        #region METHODS


        #endregion
    }
}
