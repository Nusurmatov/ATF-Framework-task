using System;
using System.IO;

namespace Framework.Utils
{
    public class UserCreator
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string Browser { get; set; }

        public UserCreator(string environment)
        {
            this.Name = ExtractValueFromFile(environment, "Name");
            this.Password = ExtractValueFromFile(environment, "Password");
            this.Browser = ExtractValueFromFile(environment, "Browser");
        }

        private string ExtractValueFromFile(string environment, string property)
        {
            string result = String.Empty;
            using (var reader = new StreamReader(@$"C:\Users\Xusniddin\Desktop\Khusniddin\IT\Automed Testing\LocalRepo\ATF-Framework-task\Sources\{environment}.properties"))
            {
                string line; 
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(property))
                    {
                        result = line.Substring(line.IndexOf('=') + 1);
                    }
                }
            }

            return result;
        }
    }
}
