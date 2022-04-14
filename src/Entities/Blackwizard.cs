namespace Desaf.src.Entities
{
    public class Blackwizard : Hero
    {
        public Blackwizard(string Nome, int Level, string Herotype)
        {
            this.Name = Nome;
            this.Level = Level;
            this.HeroType = Herotype;
        }

        public override string Attack()
        {
            return this.Name + "Lançou Magia";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " " + "Lançou Magia super efectiva con bonus de " + Bonus;
            } else{
                return this.Name + " " +"Lançou uma Magia com força fraca com bonus de " + Bonus;
            }


            return this.Name + " Lançou Magia com bonus de ataque de  " + Bonus;
     
        }
    }
}