﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "USER", menuName = "DATA/USER_initial", order = 2)]
public class USER_initial : ScriptableObject
{
    [Header("使用者ID")]
    public int ID;
    [Header("基本資料")]
    public USER user;
    [Header("血量")]
    public HP Hp;
    [Header("魔")]
    public MP Mp;
    [Header("現在位置")]
    public Xy XY;
    [Header("錢")]
    public money Money;
    [Header("天賦")]
    [Header("移動 = 0 , 跳 = 1 , 力量 = 2 , 敏捷 = 3 , 智慧 = 4")]
    public int[] talent;
    [Header("聊天室")]
    public string[] chatroom;
    [Header("狀態")]
    public control[] Ctrl;//狀態ID

    [Header("背包上限")]
    public int backpackMax;
    [Header("背包")]
    public Backpack[] backpack;
    [Header("動畫背包")]
    public anim[] Anim;
    [Header("動畫上限")]
    public int Anim_max;
    [Header("欄位啟用")]
    [Header("right_1, right_2, right_3, left_1, left_2, left_3, pet_skill_1, pet_skill_2")]
    public bool[] Skill/*玩家購買*/,Skill_op/*玩家開啟*/;
    #region 玩家基本資料庫
    #region HP
    [System.Serializable]
    public struct HP    /*HP*/
    {
        [Header("目前血量")]
        public float Hp;/*目前HP*/
        [Header("血量上限")]
        public float Hpmax;/*HP上限*/
    }
    #endregion
    #region MP
    [System.Serializable]
    public struct MP   /*MP*/
    {
        [Header("目前MP")]
        public float Mp;/*目前MP*/
        [Header("最大MP上限")]
        public float Mpmax;/*最大MP上限*/
    }
    #endregion
    #region XY
    [System.Serializable]
    public struct Xy   /*XY*/
    {
        [Header("現在位置")]
        public float X, Y, Z;/*現在位置xyz*/
        [Header("所在地圖")]
        public World.map map;
        public float Camera;
    }
    #endregion
    #region 錢
    [System.Serializable]
    public struct money/*金錢*/
    {
        [Header("主城市")]
        public int gold, silver, copper/*主城市*/;

    }
    #endregion
    #region 使用者資料
    [System.Serializable]
    public struct USER/*使用者資料*/
    {
        [Header("玩家名字")]
        public string Name/*名字*/;
        [Header("遊戲ID")]
        public string Id/*遊戲ID*/;
        [Header("職業")]
        [Space(-10)]
        [Header("  沒職業 = NO , warrior = 戰士 , 弓手 = Archer, 法師 = Mage, 刺客 = assassin, 槍手 = Gunman")]
        public Career Mod/*職業*/;
        [Header("等級")]
        public int LV;
        [Header("經驗值")]
        public int experience;
        [Header("性別")]
        public surname Surname;
        public enum surname
        {
            NO,
            men,
            women
        };
    }
    public enum Career
    {
        NO = 0,
        warrior = 1,
        Archer = 2,
        Mage = 3,
        assassin = 4,
        Gunman = 5
    }
    #endregion
    #region 背包

    [System.Serializable]
    public struct Backpack
    {
        [Header("自訂名稱")]
        public string Name;
        [Header("物件ID")]
        public int ID;//物件ID
        [Header("剩餘耐久")]
        public float Consumption;//損耗率
        [Header("數量")]
        public int Quantity;
        [Header("道具列")]
        public Skill_ skill;//預設=0,如在狀態列上=狀態列ID
                           /// <summary>
                           /// 
                           /// </summary>
                           /// <param name="name">特殊名稱</param>
                           /// <param name="iD">物件ID</param>
                           /// <param name="consumption">耐久</param>
                           /// <param name="quantity">數量</param>
                           /// <param name="skill">道具列</param>
        public Backpack(string name, int iD, float consumption, int quantity, Skill_ skill) : this()
        {
            Name = name;
            ID = iD;
            Consumption = consumption;
            Quantity = quantity;
            this.skill = skill;
        }
    }
    #endregion
    #region 動畫背包

    [System.Serializable]
    public struct anim
    {
        [Header("自訂名稱")]
        public string Name;
        [Header("物件ID")]
        public int ID;//物件ID
        [Header("道具列")]
        [Header("放置位置以放在右手欄為代表")]
        public Skill_ skill;//預設=0,如在狀態列上=狀態列ID

        public anim(string name, int iD, Skill_ skill) : this()
        {
            Name = name;
            ID = iD;
            this.skill = skill;
        }
    }
    #endregion
    #region 控制用

    [System.Serializable]
    public struct control
    {
        /*發生事件*//*道具ID OR 事件名字*/
        public string name;
        public int ID;
        /*說明*/
        public string Description;
        /*模式*/
        public MOD mod;
        /*值and時間*/
        public float value, max, time;

    }
    [System.Serializable]
    public enum MOD
    {
        mobile,/*移動*/
        jump,/*跳躍*/
        Stun,/*暈眩*/
        HP,/*血量*/
        MP/*魔力*/
    }
    #endregion
    #region 道具列選單
    [System.Serializable]
    public enum Skill_
    {
        No = 0,
        right_1,
        right_2,
        right_3,
        right_4,
        right_5,
        left_1,
        left_2,
        left_3,
        left_4,
        left_5,
        head,//頭
        body,//身體
        leg,//腿
        foot,//腳
        Ring,//戒指
        necklace, //項鍊
        gloves,//手套
        Special_props//特殊道具
    }
    #endregion
    #endregion
}