using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OlympicGamesMesecher.Models
{
    public class OlympicSession
    {
        private const string CountriesKey = "mycountries";
        private const string CountKey = "countrycount";
        private const string GameKey = "game";
        private const string CtgyKey = "ctgy";

        private ISession session { get; set; }
        public OlympicSession(ISession session) {
            this.session = session;
        }

        public void SetMyCountries(List<Country> countries) {
            session.SetObject(CountriesKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }
        public List<Country> GetMyCountries() =>
            session.GetObject<List<Country>>(CountriesKey) ?? new List<Country>();
        public int GetMyCountryCount() => session.GetInt32(CountKey) ?? 0;

        public void SetActiveGm(string activeGm) =>
            session.SetString(GameKey, activeGm);
        public string GetActiveGm() => session.GetString(GameKey);

        public void SetActiveCtgy(string activeCtgy) =>
            session.SetString(CtgyKey, activeCtgy);
        public string GetActiveCtgy() => session.GetString(CtgyKey);

        public void RemoveMyCountries() {
            session.Remove(CountriesKey);
            session.Remove(CountKey);
        }
    }
}