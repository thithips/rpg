namespace dotnet.src.Entities
{
    public class Wizard:Hero
    {
        public Wizard(
            string Name,
            int Level,
            string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " lançou magia"; 
        }

        public string Attack(int Bonus){
            return this.Name + " lançou magia com bonus de ataque de " + Bonus;
        }
    }
}