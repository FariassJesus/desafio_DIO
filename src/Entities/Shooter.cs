namespace game.src.Entities
{
    public class Shooter : Champion
    {
        public Shooter(string Name,
            int Level,
            string ChampionType,
            int HP)
            {
                this.Name = Name;
                this.Level = Level;
                this.ChampionType = ChampionType;
                this.HP = HP;
            }
        public override string Attack()
        {
            return this.Name + " atirou com sua arma!";
        }
        
    }
}
    
