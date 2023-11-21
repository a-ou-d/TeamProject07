﻿namespace TeamProject07.Utils
{
    internal class Define
    {
        public enum GameStages
        {
            Intro,
            Login,
            Base,
            Stat,
            Battle,
        }

        public enum MainGamePhase
        {
            Exit = 0,
            Status,
            Inventory,
            Shop,
            Dungeon,
            Hotel,
            Main,
            temp
        }

        public enum Parts
        {
            Weapon,
            Head,
            Body,
            Hand,
            Foot,
            Accessory
        }

        public enum SkillTypes
        {
            Buff,
            DeBuff,
        }

        public enum Buff 
        {
            atk,
            def,
            cri,
            dex,
            maxHp,
            maxMp,
            hp,
            mp
        }

        public enum SetEquip
        {
            종이세트,
            천세트,
            나무세트,
            강철세트
        }
        public enum ItemType
        {
            Equip,
            Consum
        }


        public static string ItemPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent + "\\CSV\\ItemData.csv";
        public static string MonsterPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent + "\\CSV\\MonsterData.csv";
        public static string ShopPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent + "\\CSV\\ShopDialogue.csv";
        public static string SkillPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent + "\\CSV\\SkillData.csv";



    }
}
