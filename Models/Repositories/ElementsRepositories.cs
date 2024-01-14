using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rock_paper_scissors_api.Models.Repositories
{
    public static class ElementsRepositories
    {
        private static List<Element> elements = new List<Element>(){
            new Element {Id=1, Name="Spock"},
            new Element {Id=2, Name="Scissors"},
            new Element {Id=3, Name= "Paper"},
            new Element {Id=4, Name="Rock"},
            new Element {Id=5, Name="Lizard"},
        };
        public static List<Element> GetElements()
        {
            return elements;
        }
        public static Element GetElementByName(string name)
        {
            return elements.FirstOrDefault(x => x.Name == name);
        }
        public static Element GetElementById(int id)
        {
            return elements.FirstOrDefault(x => x.Id == id);
        }
    }
}