using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EyeMod.Items
{
	internal class KingCreeperSummon : ModItem
	{

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Shivering Eye");
			Tooltip.SetDefault("This doesn't look safe. Nor stable. Maybe we should leave it alone...");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 14;
			item.rare = 10;
			item.maxStack = 20;
			item.useStyle = 4;
			item.useTime = 45;
			item.useAnimation = 45;
			item.consumable = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Lens, 6);
			recipe.AddIngredient(ItemID.VileMushroom, 1);
			recipe.AddIngredient(ItemID.ViciousMushroom, 1);
			recipe.AddIngredient(ItemID.SuspiciousLookingEye, 1);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
