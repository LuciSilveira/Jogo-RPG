
namespace PROJETO_JOGO_RPG.CRC.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;    
        }
        public override string Attack(){
              return this.Name + " Atacou com a sua espada";
        }      
    }
}