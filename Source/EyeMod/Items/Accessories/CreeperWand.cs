using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace EyeMod.Items.Accessories
{
	public class CreeperWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Double tap a direction to teleport a far distance.");
		}
		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = 450000;
			item.rare = -12;
		}
	}
}