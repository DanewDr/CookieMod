using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Placeable
{
	public class CrunchSink : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crunch Sink");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.width = 60;
			item.height = 40;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 1000;
			item.createTile = mod.TileType("CrunchSink");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CrunchWood", 6);
			recipe.AddIngredient(ItemID.WaterBucket);
			recipe.AddTile(TileID.WorkBenches);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}	
	}
}