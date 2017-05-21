using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace c_vega.Models
{
    public class Make
    {
        public int id {get; set;}
        public string Name {get;set;}
        public ICollection<Model> Models{get; set;}
        
        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}