using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Gideon
{
    public class Institution
    {
        private string name;
        private string region;
        private string country;

        //Creates institution object
        public Institution(string name, string region, string country)
        {
            this.name = name;
            this.region = region;
            this.country = country;
        }
        //returns object as a string
        public string InstitutionInfo()
        {
            return $"Institution: {name}\nRegion: {region}\nCountry: {country}";
        }
        public string Name
        {
            get { return name; }
        }
        public string Region
        {
            get { return region; }
        }
        public string Country
{
            get { return country; }
        }
    }
}
