namespace RPG.src.Entities
{
    public abstract class Hero 
    {
        //Declarando propriedade
        public string Name;
        public int Level;
        public int Hp;
        public int Mp;
        public string HeroType;

        //Método Construtor
        public Hero(string name,int hp, int mp,int level,string heroType){
            this.Name = name;
            this.Level = level;
            this.Mp = mp;
            this.Hp = hp;
            this.HeroType = heroType;
        }
        public Hero (){
            
        }


        //Método
        public override string ToString(){
            return this.Name + "  "
            + this.Hp + " "
            + this.Mp + " "
            + this.HeroType + " "
            +this.Level;

        }

        //Marcar o método como virtual, para permitir que classes que herdam da classe-mãe, permita a classe filho alterar o método
        public virtual string Attack(){
            return this.Name + " Atacou com sua espada de fogo";
        }
            
        
    }
}