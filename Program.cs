using System.ComponentModel.Design.Serialization;
using FFCE.Data;
using FFCE.Models;

namespace FFCE {
    public class Program {
        public static void Main(string[] args){
            using (var context = new FloricultureDataContext()){
/* This code snippet is creating a new instance of the `Flower` class with the
properties `Name` set to "Rosa", `Url` set to "google.com", and `Price` set to
9.9f. */
            var rose = new Flower{Name="Rosa",Url="google.com", Price=9.9f };
            context.Flowers.Add(rose);
            context.SaveChanges(); 
            
          
/* This code snippet is retrieving the first `Flower` object from the database
using the `FirstOrDefault()` method. It then updates the `Name` property of the
retrieved `Flower` object to "Rosa Vermelha". After updating the object, it
calls `context.Update(rose)` to inform the database context that the object has
been modified. Finally, `context.SaveChanges()` is called to persist the changes
to the database. */
            rose = context.Flowers.FirstOrDefault(); 
            rose.Name = "Rosa Vermelha";
            context.Update(rose);
            context.SaveChanges();
           
/* This code snippet is retrieving the first `Flower` object from the database
using the `FirstOrDefault()` method. It then removes the retrieved `Flower`
object from the database by calling `context.Remove(rose)`. Finally,
`context.SaveChanges()` is called to persist the removal of the object to the
database. */
            rose = context.Flowers.FirstOrDefault(); 
            context.Remove(rose);
            context.SaveChanges();
            }
            
           
        }
    }
}