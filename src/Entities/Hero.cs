namespace Desaf.src.Entities
{
    public abstract class Hero
    {
     //Metodo constructor ctr y ctor y viene directo
    //public Arus(Parameters)
       public Hero(string Nome, int Level, string Herotype)
        {
            this.Name = Nome;
            this.Level = Level;
            this.HeroType = Herotype;
        
        }
        public Hero(){

        } 
        public string Name;
        public int Level;
        public string HeroType;

        //creo un metodo

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + "Atacou com a sua espada";
        }
        

    }
}