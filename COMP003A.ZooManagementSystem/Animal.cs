using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
   public abstract class Animal
    {
        private string _name;
        private string _species;
       public int Age { get; set; }
        public string Name
            {
            get { return _name; }
            
            
            set {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Must enter a name");
                
                _name = value;
            }
        }
        
        public string Species
        {
            get { return _species; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Must enter a Species");
                    _species = value; }
        }

      
        public abstract void MakeSound();

    }
   
    
    

}
