using System;
using System.Collections.Generic;

namespace Flow_Control
{
    internal class Party
    {
        private List<CinemaGoer> cinemaParty; //Hidden

        public Party() //CTOR
        {
            cinemaParty = new List<CinemaGoer>();
        }

        internal void AddMember(CinemaGoer member) // already CinemaGoer
        {
            cinemaParty.Add(member);
        }

        public CinemaGoer[] GetMembers()
        {
            return cinemaParty.ToArray(); // kopia
        }
    }
}