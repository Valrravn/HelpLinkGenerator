using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelpLinkGenerator {
    public class SearchEngineCore {

        public static List<Article> GetCustomDocs(string repoPath, string productName) {
            List<Article> customDocs = new List<Article>();
            string fullPath = repoPath + "\\" + productName + "\\articles";
            string Owner = String.Empty;
            string ID = String.Empty;
            string Title = String.Empty;
            string shortName = String.Empty;
            foreach (string file in Directory.EnumerateFiles(fullPath, "*.md", SearchOption.AllDirectories)) {
                List<string> contents = File.ReadAllText(file).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (string line in contents) {
                    Article art = new Article();
                    if (line.Contains("uid: ")) ID = Regex.Replace((line.Replace("uid: ", String.Empty).Trim()), "[^0-9]", "");
                    if (line.Contains("title: ")) Title = line.Replace("title: ", String.Empty).Trim();
                    if (line.Contains("owner: ")) Owner = line.Replace("owner: ", String.Empty).Trim();
                }
                shortName = file.Remove(0, repoPath.Length + 1); ;
                shortName = shortName.Remove(0, productName.Length + 1); //remove product name
                shortName = shortName.Remove(0, 9); //remove 'articles' + slash
                customDocs.Add(new Article(Title, Owner, ID, shortName));
            }

            return customDocs;
        }

        public static List<string> GetFullFieldNames(string repoPath, string productName, string moduleName) {
            List<string> fullFileNames = new List<string>();
            //List<string> trimmedNames = new List<string>();
            List<string> memberNames = new List<string>();
            List<string> classNames = new List<string>();
            List<string> nspNames = new List<string>();
            List<string> exampleNames = new List<string>();
            List<string> templateNames = new List<string>();
            string unit = String.Empty;
            string fullPath;
            switch (moduleName) {
                case ("Members"): unit = "apidoc"; break;
                case ("Classes"): unit = "apidoc"; break;
                case ("Namespaces"): unit = "apidoc"; break;
                case ("Articles"): unit = "articles"; break;
                case ("Examples"): unit = "examples"; break;
                case ("Templates"): unit = "templates"; break;
            }

            fullPath = repoPath + "\\" + productName + "\\" + unit;
            fullFileNames = Directory.GetFiles(fullPath, "*", SearchOption.AllDirectories)
             .Where(s => (Path.GetExtension(s).ToLower() == ".md")).ToList<string>();
            //trim file names
            //trimmedNames.Clear();
            for (int i = 0; i < fullFileNames.Count(); i++) {
                string shortName = fullFileNames.ElementAt(i).Remove(0, repoPath.Length + 1); //remove root path
                shortName = shortName.Remove(0, productName.Length + 1); //remove product name
                shortName = shortName.Remove(0, unit.Length + 1); //remove sub-folder name + slash
                //trimmedNames.Add(shortName); //DEBUG
                switch (unit) {
                    case ("examples"):
                        exampleNames.Add(shortName);
                        break;
                    case ("templates"):
                        templateNames.Add(shortName);
                        break;
                    case ("apidoc"):
                        string[] splitString = shortName.Split('\\');
                        if (splitString.Length == 2) { //namespace has 2 name blocks (e.g, "DevExpress.DataAccess.UI\\DevExpress.DataAccess.UI.md")
                            nspNames.Add(shortName);
                        }
                            else if (splitString[1].Equals(splitString[2].Remove(splitString[2].Length - 3, 3))) {
                                classNames.Add(shortName); //class (e.g, "DevExpress.DataAccess.UI\\FilterEditorControl\\FilterEditorControl.md")
                        }
                                else memberNames.Add(shortName);
                        break;
                } 
            }
            fullFileNames.Clear();

            switch (moduleName) {
                case ("Members"): return memberNames;
                case ("Classes"): return classNames;
                case ("Namespaces"): return nspNames;
                case("Examples"): return exampleNames;
                case ("Templates"): return templateNames;
                default: return fullFileNames;
            }
        }


    }

    public class Article {
        public string Name;
        public string Owner;
        public string ID;
        public string FullName;
        public Article() { }
        public Article(string name, string owner, string iD, string fullName) {
            Name = name;
            Owner = owner;
            ID = iD;
            FullName = fullName;
        }
    }
}
