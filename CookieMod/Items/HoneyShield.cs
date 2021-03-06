using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items     //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Shield)]
	public class HoneyShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Shield");
			Tooltip.SetDefault("Grants immunity to knockback\n8% summoner damage increase");
		}		
        public override void SetDefaults()
        {
            item.width = 24;   //The size in width of the sprite in pixels.
            item.height = 28;    //The size in height of the sprite in pixels.
            item.value = Item.buyPrice(0, 2, 0, 0); //  How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 2 gold)
            item.rare = 4;          //The color the title of your Weapon when hovering over it ingame        
            item.accessory = true;  //this make the item an accessory, so you can equip it
            item.defense = 2;   //this sets the item defense given when equipped
 
        }
        public override void UpdateAccessory(Player player, bool hideVisual)  //this is so when the item is equipped will give this stats to the player
        {
            player.noKnockback = true;   //so the player is immune to knockback
      player.minionDamage = .08f;
        }
 
 
        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CobaltShield, 1);      //this is how to add an ingredient from Terraria,  so for crafting this item you need 1 Cobalt Shield      
            recipe.AddIngredient(null, "HoneyCookie", 4);       //and 4 lifecristals
            recipe.AddTile(TileID.Anvils);  //this is where craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
 
    }
}
