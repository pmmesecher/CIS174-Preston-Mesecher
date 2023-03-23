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
                games = new List<Game> {
                    new Game{ GameID = "all", Name = "All" } };
                games.AddRange(value);
            }
        }

        private List<Category> categorys;
        public List<Category> Categories
        {
            get => categorys;
            set
            {
                categorys = new List<Category> {
                    new Category { CategoryID = "all", Name = "All" } };
                categorys.AddRange(value);
            }
        }


        public string CheckActiveGm(string c) =>
            c.ToLower() == ActiveGm.ToLower() ? "active" : "";

        public string CheckActiveCtgy(string d) =>
            d.ToLower() == ActiveCtgy.ToLower() ? "active" : "";
    }
}