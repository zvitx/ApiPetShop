namespace PetShopApi.Models
{
    public class PetShop
    {
        public string name { get; set; }
        public double distance { get; internal set; }
        public double smallDogPrice { get; set; }
        public double largeDogPrice { get; set; }
        public double smallDogWeekend { get; set; }
        public double largeDogWeekend { get; set; }

        public double PrecoNormal(int cachorroPequeno, int cachorroGrande)
        {
            return smallDogPrice * cachorroPequeno + largeDogPrice * cachorroGrande;
        }
        public double PrecoFimSemana(int cachorroPequeno, int cachorroGrande)
        {
            return smallDogWeekend * cachorroPequeno + largeDogWeekend * cachorroGrande;
        }
    }
}