using Microsoft.EntityFrameworkCore;

namespace OlympicGamesMesecher.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(
                new Game{ GameID = "Winter Olympics", Name = "Winter Olympics" },
                new Game{ GameID = "Summer Olympics", Name = "Summer Olympics" },
                new Game { GameID = "Paralympics", Name = "Paralympics" },
                new Game { GameID = "Youth Olympic Games", Name = "Youth Olympic Games" }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "Curling/Indoor", Name = "Curling/Indoor" },
                new Category { CategoryID = "Bobsleigh/Outdoor", Name = "Bobsleigh/Outdoor" },
                new Category { CategoryID = "Diving/Indoor", Name = "Diving/Indoor" },
                new Category { CategoryID = "RoadCycling/Outdoor", Name = "RoadCycling/Outdoor" },
                new Category { CategoryID = "Archery/Indoor", Name = "Archery/Indoor" },
                new Category { CategoryID = "Canoe Sprint/Outdoor", Name = "Canoe Sprint/Outdoor" },
                new Category { CategoryID = "Breakdancing/Indoor", Name = "Breakdancing/Indoor" },
                new Category { CategoryID = "Skateboarding/Outdoor", Name = "Skateboarding/Outdoor" }
            );
            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "Can", Name = "Canada", GameID = "Winter Olympics", CategoryID = "Curling/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_ca-flag.gif" },
                new { CountryID = "Swe", Name = "Sweden", GameID = "Winter Olympics", CategoryID = "Curling/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_sw-flag.gif" },
                new { CountryID = "Gre", Name = "Great Britain", GameID = "Winter Olympics", CategoryID = "Curling/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_uk-flag.gif" },
                new { CountryID = "Jam", Name = "Jamaica", GameID = "Winter Olympics", CategoryID = "Bobsleigh/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_jm-flag.gif" },
                new { CountryID = "Ita", Name = "Italy", GameID = "Winter Olympics", CategoryID = "Bobsleigh/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_it-flag.gif" },
                new { CountryID = "Jap", Name = "Japan", GameID = "Winter Olympics", CategoryID = "Bobsleigh/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_ja-flag.gif" },
                new { CountryID = "Ger", Name = "Germany", GameID = "Summer Olympics", CategoryID = "Diving/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_gm-flag.gif" },
                new { CountryID = "Chi", Name = "China", GameID = "Summer Olympics", CategoryID = "Diving/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_ch-flag.gif" },
                new { CountryID = "Mex", Name = "Mexico", GameID = "Summer Olympics", CategoryID = "Diving/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_mx-flag.gif" },
                new { CountryID = "Bra", Name = "Brazil", GameID = "Summer Olympics", CategoryID = "RoadCycling/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_br-flag.gif" },
                new { CountryID = "Net", Name = "Netherlands", GameID = "Summer Olympics", CategoryID = "RoadCycling/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_nl-flag.gif" },
                new { CountryID = "USA", Name = "USA", GameID = "Summer Olympics", CategoryID = "RoadCycling/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_us-flag.gif" },
                new { CountryID = "Tha", Name = "Thailand", GameID = "Paralympics", CategoryID = "Archery/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_th-flag.gif" },
                new { CountryID = "Uru", Name = "Uruguay", GameID = "Paralympics", CategoryID = "Archery/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_uy-flag.gif" },
                new { CountryID = "Ukr", Name = "Ukraine", GameID = "Paralympics", CategoryID = "Archery/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_up-flag.gif" },
                new { CountryID = "Aus", Name = "Austria", GameID = "Paralympics", CategoryID = "Canoe Sprint/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_au-flag.gif" },
                new { CountryID = "Pak", Name = "Pakistan", GameID = "Paralympics", CategoryID = "Canoe Sprint/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_pk-flag.gif" },
                new { CountryID = "Zim", Name = "Zimbabwe", GameID = "Paralympics", CategoryID = "Canoe Sprint/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_zi-flag.gif" },
                new { CountryID = "Fra", Name = "France", GameID = "Youth Olympic Games", CategoryID = "Breakdancing/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_fr-flag.gif" },
                new { CountryID = "Cyp", Name = "Cyprus", GameID = "Youth Olympic Games", CategoryID = "Breakdancing/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_cy-flag.gif" },
                new { CountryID = "Rus", Name = "Russia", GameID = "Youth Olympic Games", CategoryID = "Breakdancing/Indoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_rs-flag.gif" },
                new { CountryID = "Fin", Name = "Finland", GameID = "Youth Olympic Games", CategoryID = "Skateboarding/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_fi-flag.gif" },
                new { CountryID = "Slo", Name = "Slovakia", GameID = "Youth Olympic Games", CategoryID = "Skateboarding/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_lo-flag.gif" },
                new { CountryID = "Por", Name = "Portugal", GameID = "Youth Olympic Games", CategoryID = "Skateboarding/Outdoor", LogoImage = "https://www.worldometers.info/img/flags/small/tn_po-flag.gif" }
            );
        }
    }
}
