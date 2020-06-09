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
			// DisplayName.SetDefault("CreeperWand"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
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

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}