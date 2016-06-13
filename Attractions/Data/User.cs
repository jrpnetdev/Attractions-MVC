using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Attractions.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private ICollection<Attraction> _favourites;
        public ICollection<Attraction> Favourites
        {
            get { return _favourites ?? (_favourites = new Collection<Attraction>()); }
            set { _favourites = value; }
        }
    }
}