using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Prototype_Pattern
{
    public class Settings : ICloneable
    {
        public Settings()
        {
            // Load ApplicationSettings from Configuation 
            // Load ThemeSettings from Database

            ApplicationSettings = "ApplicationSettings";
            ThemeSettings = "ThemeSettings";
            UserSettings = "UserSettings";
        }
        public string ApplicationSettings { get; set; }
        public string ThemeSettings { get; set; }
        public string UserSettings { get; set; }    

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return this.ApplicationSettings + "" + 
                   this.ThemeSettings + "" + this.UserSettings;
        }
    }
}
