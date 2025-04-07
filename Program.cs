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

            //Update
            }
        }
    }
}