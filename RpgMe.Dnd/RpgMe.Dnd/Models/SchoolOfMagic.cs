using Ardalis.SmartEnum;

namespace RpgMe.Dnd.Models
{
    public sealed class SchoolOfMagic : SmartEnum<SchoolOfMagic>
    {
        public static readonly SchoolOfMagic Abjuration = new SchoolOfMagic(nameof(Abjuration), 1);
        public static readonly SchoolOfMagic Conjuration = new SchoolOfMagic(nameof(Conjuration), 2);
        public static readonly SchoolOfMagic Divination = new SchoolOfMagic(nameof(Divination), 3);
        public static readonly SchoolOfMagic Enchantment = new SchoolOfMagic(nameof(Enchantment), 4);
        public static readonly SchoolOfMagic Evocation = new SchoolOfMagic(nameof(Evocation), 5);
        public static readonly SchoolOfMagic Illusion = new SchoolOfMagic(nameof(Illusion), 6);
        public static readonly SchoolOfMagic Necromancy = new SchoolOfMagic(nameof(Necromancy), 7);
        public static readonly SchoolOfMagic Transmutation = new SchoolOfMagic(nameof(Transmutation), 8);

        private SchoolOfMagic(string name, int value)
            : base(name, value)
        {
        }
    }
}
