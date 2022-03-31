
namespace PROJETO_JOGO_RPG.CRC.Entities
{
    public class Topapa : Hero
    {
        public Topapa(string Name, int Level, string HeroType) : base(Name, Level, HeroType) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;   
        } 
        public override string Attack(){
            return this.Name + " Lançou magia";
        }
    }
}