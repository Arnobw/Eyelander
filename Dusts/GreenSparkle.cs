
using Terraria;
using Terraria.ModLoader;

namespace Eyelander.Dusts
{
	public class GreenSparkle : ModDust
	{
	public override void OnSpawn(Dust dust) {
			dust.velocity *= 0.5f;
			dust.noGravity = true;
			dust.noLight = true;
			dust.scale *= 0.7f;
		}

		public override bool Update(Dust dust) {
			dust.position += dust.velocity;
			dust.rotation += dust.velocity.X * 0.15f;
			dust.scale *= 0.99f;
			float light = 0.35f * dust.scale;
			Lighting.AddLight(dust.position, 0.1f, 0.5f, 0.1F);
			if (dust.scale < 0.5f) {
				dust.active = false;
			}
			return false;
		}
	}
}
