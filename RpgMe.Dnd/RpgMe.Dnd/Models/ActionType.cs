using Ardalis.SmartEnum;
using RpgMe.Dnd.Extensions;

namespace RpgMe.Dnd.Models
{
	public class ActionType : SmartEnum<ActionType>
	{
		public static readonly ActionType Action = new ActionType(1, nameof(Action));
		public static readonly ActionType BonusAction = new ActionType(2, nameof(BonusAction).SplitPascalCase());
		public static readonly ActionType Reaction = new ActionType(3, nameof(Reaction));

		private ActionType(int id, string name) : base(name, id) { }
	}
}
