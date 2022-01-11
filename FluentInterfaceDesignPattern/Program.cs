using System;
using System.Text;

namespace FluentInterfaceDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero kaleTron = FluentHeroFactory.
                Init()
                .GiveAvatarPath("c:\\kaleTron.jpg")
                .GiveNickName("Kaletron")
                .GiveColor("Gold")
                .SetForceTo(60)
                .TakeAHero();

            // Farkı

            Hero known = new Hero
            {
                AvatarAdres = Encoding.UTF8.GetBytes("d:\\known.jpg"),
                Color = "Red",
                InitialForce = 50,
                NickName = "known"
            };
            Console.WriteLine("Hello World!");
        }

        private static string GetAvatar(string PicAddres)
        {
            throw new NotImplementedException();
        }
    }
    interface IHeroFactory
    {
        Hero TakeAHero();
        IHeroFactory SetForceTo(int ForceValue);
        IHeroFactory GiveNickName(string NickName);
        IHeroFactory GiveAvatarPath(string AvatarAdres);
        IHeroFactory GiveColor(string Color);
    }
    class HeroFactory : IHeroFactory
    {
        private Hero _hero = null;

        public HeroFactory(Hero hero)
        {
            _hero = hero;
        }
        public IHeroFactory GiveAvatarPath(string AvatarAdres)
        {
            this._hero.AvatarAdres = Encoding.UTF8.GetBytes(AvatarAdres);
            return this;
        }

        public IHeroFactory GiveColor(string Color)
        {
            this._hero.Color = Color;
            return this;
        }

        public IHeroFactory GiveNickName(string NickName)
        {
            this._hero.NickName = NickName;
            return this;
        }

        public IHeroFactory SetForceTo(int ForceValue)
        {
            this._hero.InitialForce = ForceValue;
            return this;
        }

        public Hero TakeAHero()
        {
            return this._hero;
        }
    }
    static class FluentHeroFactory
    {
        public static IHeroFactory Init()
        {
            return new HeroFactory(new Hero());
        }
    }
    class Hero
    {
        public string Color { get; set; }
        public byte[] AvatarAdres { get; set; }
        public string NickName { get; set; }
        public int InitialForce { get; set; }
    }
}
