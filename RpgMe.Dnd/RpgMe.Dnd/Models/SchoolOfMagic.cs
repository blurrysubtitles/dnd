using Ardalis.SmartEnum;

namespace RpgMe.Dnd.Models
{
    public class SchoolOfMagic : SmartEnum<SchoolOfMagic>
    {
        public static readonly SchoolOfMagic Unknown = new SchoolOfMagic(0, nameof(Unknown));
        public static readonly SchoolOfMagic Abjuration = new SchoolOfMagic(1, nameof(Abjuration));
        public static readonly SchoolOfMagic Conjuration = new SchoolOfMagic(2, nameof(Conjuration));
        public static readonly SchoolOfMagic Divination = new SchoolOfMagic(3, nameof(Divination));
        public static readonly SchoolOfMagic Enchantment = new SchoolOfMagic(4, nameof(Enchantment));
        public static readonly SchoolOfMagic Evocation = new SchoolOfMagic(5, nameof(Evocation));
        public static readonly SchoolOfMagic Illusion = new SchoolOfMagic(6, nameof(Illusion));
        public static readonly SchoolOfMagic Necromancy = new SchoolOfMagic(7, nameof(Necromancy));
        public static readonly SchoolOfMagic Transmutation = new SchoolOfMagic(8, nameof(Transmutation));

        private SchoolOfMagic(int id, string name) : base(name, id) { }
    }
}
