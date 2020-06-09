using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EyeMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class atd1010devhelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("M3M31UrD's Wear");
			Tooltip.SetDefault("The legendary helmet of our creator himself, M3M31UrD.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 900000;
			item.rare = -12;
			item.defense = 80;
		}
	}
}