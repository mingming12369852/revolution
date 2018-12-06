using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Foot color", menuName = "DATA/Foot_color", order = 4)]
public class Foot_color : ScriptableObject
{
    public string[] Point_category_zh;
    public string[] npc_dialogue;
    public point[] xyz;
    public point[] Character;



    //
    [System.Serializable]
    public struct point
    {
        public string name;
        public Vector3 Transform;



        public Point_category Class;
    }


    [System.Serializable]
    public struct Npc_dialogue
    {
        public int[] haha;
        public string text;


    }

    [System.Serializable]
    public struct character
    {
        public string name;
        public GameObject NPC;
    }


    [System.Serializable]
    public enum Point_category
    {
        no,bus, building, Landscaping
    }
}
