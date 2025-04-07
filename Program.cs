using System.ComponentModel.Design.Serialization;
using FFCE.Data;
using FFCE.Models;

namespace FFCE {
    public class Program {
        public static void Main(string[] args){
            using (var context = new FloricultureDataContext()){
            //CREATE ID-NAME-url-Price
            var rose = new Flower{Name="Rosa",Url="google.com", Price=9.9f };
            context.Flowers.Add(rose);
            context.SaveChanges(); //Salvando no banco
            //-----------------
            //Update
            rose = context.Flowers.FirstOrDefault(); //Rehidratação
            rose.Name = "Rosa Vermelha";
            context.Update(rose);
            context.SaveChanges();
            //--------------
            //Delete
            rose = context.Flowers.FirstOrDefault(); //Rehidratação
            context.Remove(rose);
            context.SaveChanges();
            }
            
           
        }
    }
}