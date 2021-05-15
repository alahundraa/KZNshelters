using System;

namespace KZNshelter.Models
{
    public class Pet
    {
        public readonly int Id;
        public string img_path { get; set; }
        public DateTime Age { get; set; }
        public bool Gender { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        
        public Pet(int id)
        {
            Id = id;
        }
        public Pet()
        {

        }
    }
}