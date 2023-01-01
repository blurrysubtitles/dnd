using Ardalis.SmartEnum;

namespace RpgMe.Dnd.Models
{
    public sealed class SpellLevel : SmartEnum<SpellLevel>
    {
        public static readonly SpellLevel Zero = new SpellLevel("Cantrip", 0);
        public static readonly SpellLevel One = new SpellLevel("1st", 1);
        public static readonly SpellLevel Two = new SpellLevel("2nd", 2);
        public static readonly SpellLevel Three = new SpellLevel("3rd", 3);
        public static readonly SpellLevel Four = new SpellLevel("4th", 4);
        public static readonly SpellLevel Five = new SpellLevel("5th", 5);
        public static readonly SpellLevel Six = new SpellLevel("6th", 6);
        public static readonly SpellLevel Seven = new SpellLevel("7th", 7);
        public static readonly SpellLevel Eight = new SpellLevel("8th", 8);
        public static readonly SpellLevel Nine = new SpellLevel("9th", 9);

        private SpellLevel(string name, int value)
            : base(name, value)
        {
        }
    }
}
