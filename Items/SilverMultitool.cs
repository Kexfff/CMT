using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CMT.Items
{
    public class SilverMultitool : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Silver Multitool");
		}
		public override void SetDefaults()
        {
            item.damage = 7;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 23;
			item.useAnimation = 25;
			item.pick = 45;
			item.axe = 14;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverAxe, 1);
			recipe.AddIngredient(ItemID.SilverPickaxe, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
