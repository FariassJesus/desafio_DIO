using static System.Console;

namespace game.src.Entities
{
    public abstract class Champion
    {
        public Champion(
            string Name,
            int Level,
            string ChampionType,
            int HP
            // int MP,
            // int Energy
            )
            {
                this.Name = Name;
                this.Level = Level;
                this.ChampionType = ChampionType;
                this.HP = HP;
                // this.MP = MP;
                // this.Energy = Energy;
            }
           
        public Champion()
        {

        }
        public string Name;
        public int Level;
        public string ChampionType;
        public int HP;
        // public int MP;
        // public int Energy;
        public override string ToString()//método que corrige a impressão do objeto no arquivo main
        {
            return this.Name + "| Level: "
            + this.Level + "| Classe: " 
            + this.ChampionType + "| Vida: " + this.HP;
        }
        public virtual string Attack()
        {
            return this.Name;
        }



    }    
}