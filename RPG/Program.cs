using RPG.src.Entities;
using System;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string []ars)
        {

            Console.WriteLine("Dados do personagem: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level: ");
            int level = int.Parse(Console.ReadLine());
            Console.Write("HP: ");
            int hp = int.Parse(Console.ReadLine());
            Console.Write("MP: ");
            int mp = int.Parse(Console.ReadLine());
            Console.WriteLine("Hero Type: ");
            Console.WriteLine("1 - Knight | 2 - Wizard | 3 - Ninja | 4 - Black Wizard");
            int heroType = int.Parse(Console.ReadLine());
           
            
            if (heroType == 1){
                Knight knight = new Knight (name,hp,mp,level,"Knight");
                Console.WriteLine("Name: "+ knight.Name +
                                  " Level: "+knight.Level+
                                  " HP: "+knight.Hp+
                                  " MP: "+knight.Mp+
                                  " Hero Type: "+knight.HeroType);
            }
            else if (heroType == 2){
                Wizard wizard  = new Wizard (name,hp,mp,level,"Wizard");
                Console.WriteLine("Name: "+ wizard.Name +
                                  " Level: "+wizard.Level+
                                  " HP: "+wizard.Hp+
                                  " MP: "+wizard.Mp+
                                  " Hero Type: "+wizard.HeroType);
            }
            else if(heroType == 3){
                Ninja ninja = new Ninja (name,hp,mp,level,"Ninja");
                Console.WriteLine("Name: "+ ninja.Name +
                                  " Level: "+ninja.Level+
                                  " HP: "+ninja.Hp+
                                  " MP: "+ninja.Mp+
                                  " Hero Type: "+ninja.HeroType);
            }
            else if(heroType == 4){
                BlackWizard blackWizard = new BlackWizard(name,hp,mp,level,"Black Wizard");
                Console.WriteLine("Name: "+ blackWizard.Name +
                                  " Level: "+blackWizard.Level+
                                  " HP: "+blackWizard.Hp+
                                  " MP: "+blackWizard.Mp+
                                  " Hero Type: "+blackWizard.HeroType);
            }else{
                Console.WriteLine("Escolha uma das 4 opções: ");
            }

        } 
    }  
}
