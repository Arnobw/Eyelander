using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Eyelander.Dusts;
using Eyelander.Buffs;
using Microsoft.Xna.Framework;




namespace Eyelander.Items

{
	public class eyelanderSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Eyelander"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("AEAERRARHGRHGRHGHHHH");
		}

		public override void SetDefaults() 
		{
			item.damage = 65;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 50;
			item.crit = 0;
			item.scale = 1.3f;
			item.useAnimation = 50;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 200000;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


		public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(3)) {
				//Emit dusts when the sword is swung
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<GreenSparkle>());
			}
		}
public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
    {
        if (target.life <= 0) {
            player.AddBuff(ModContent.BuffType<eyelanderBuff>(), 180);

        }
    }
	
	}
}