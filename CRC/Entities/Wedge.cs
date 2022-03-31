
namespace PROJETO_JOGO_RPG.CRC.Entities
{
    public class Wedge : Hero
    {
        public Wedge(string Name, int Level, string HeroType) : base(Name, Level, HeroType) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;    
        }
        public override string Attack(){
            return this.Name + " Ataque ninja";
        }
    }
}