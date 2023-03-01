using System.Collections.Generic;

namespace OlympicGamesMesecher.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public List<Country> Countries { get; set; }


        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0,
                    new Game{ GameID = "all", Name = "All" });
            }
        }

        private List<Category> categorys;
        public List<Category> Categories
        {
            get => categorys;
            set
            {
                categorys = value;
                categorys.Insert(0,
                    new Category { CategoryID = "all", Name = "All" });
            }
        }


        public string CheckActiveGm(string c) =>
            c.ToLower() == ActiveGm.ToLower() ? "active" : "";

        public string CheckActiveCtgy(string d) =>
            d.ToLower() == ActiveCtgy.ToLower() ? "active" : "";
    }
}