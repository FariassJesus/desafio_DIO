using static System.Console;
namespace game.src.Entities
{
    public class Fighter : Champion
        {    
            
        public Fighter(string Name,
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
                return this.Name + " atacou com jab!";
            }
        }
}