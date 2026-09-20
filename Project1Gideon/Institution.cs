using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// The Institution class stores name, region and country in a institution object.
/// It contains a method that returns a public string that Form1.cs uses to display Department information.
/// Its uses public properties to control the other classes access to private information.
/// </summary>


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
