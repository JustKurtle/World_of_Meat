﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeatPlanet.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class ExterminatorBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Exterminator Breastplate");
            Tooltip.SetDefault("Break into houses!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 10;
            item.defense = 40;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.meleeDamage *= 5f;
            player.thrownDamage *= 5f;
            player.rangedDamage *= 5f;
            player.magicDamage *= 5f;
            player.minionDamage *= 5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 15);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}