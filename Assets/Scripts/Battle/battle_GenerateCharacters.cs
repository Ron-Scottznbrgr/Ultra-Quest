using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battle_GenerateCharacters : MonoBehaviour {

    private battle_GenericCharacterClass GClass;

    struct CharacterStructs
    {
        //byte 0-255
        public byte fAff, wAff, eAff, aAff;
        public byte level, xp;
        public byte atkGrowth, defGrowth, spdGrowth, hpGrowth;
        public byte spellSlots;

        //ushort 0-65535 
        public ushort atk, def, spd, hp;

        public string characterName, aiType;
    }



    GameObject Slider;
    float SliderValue;
    GameObject[] TextBox = new GameObject[9];
    Text TextField;

    // Use this for initialization
    void Start() {
        GClass = FindObjectOfType<battle_GenericCharacterClass>();
      
        

        TextBox[0] = GameObject.Find("Char1");
        TextBox[1] = GameObject.Find("Char2");
        TextBox[2] = GameObject.Find("Char3");
        TextBox[3] = GameObject.Find("Char4");

        TextBox[4] = GameObject.Find("Enemy1");
        TextBox[5] = GameObject.Find("Enemy2");
        TextBox[6] = GameObject.Find("Enemy3");
        TextBox[7] = GameObject.Find("Enemy4");

        TextBox[8] = GameObject.Find("SliderText");
        GenerateCharacters();
    }

    // Update is called once per frame
    void Update() {
        SliderValue = GameObject.Find("LevelSlider").GetComponent<Slider>().value;
        TextField = TextBox[8].GetComponent<Text>();
        TextField.text = "Level "+SliderValue;
    }

    public void GenerateCharacters()
    {
        
                   
    int num = 8;
    //num = generateNum + 4; 

    CharacterStructs[] characterArray = new CharacterStructs[num];

        
        for (int i = 0; i < num; i++)
        {
            GClass.generateValues();
            characterArray[i].characterName = GClass.characterName;
            characterArray[i].aiType = GClass.aiType;
            characterArray[i].fAff = GClass.fAff;
            characterArray[i].wAff = GClass.wAff;
            characterArray[i].eAff = GClass.eAff;
            characterArray[i].aAff = GClass.aAff;
            characterArray[i].atk = GClass.atk;
            characterArray[i].def = GClass.def;
            characterArray[i].spd = GClass.spd;
            characterArray[i].hp = GClass.hp;
            characterArray[i].xp = 0;
            characterArray[i].level = (byte)SliderValue;

            dumpText(i, characterArray[i].characterName, characterArray[i].aiType, characterArray[i].atk, characterArray[i].def, characterArray[i].spd, characterArray[i].hp, characterArray[i].fAff, characterArray[i].wAff, characterArray[i].eAff, characterArray[i].aAff, characterArray[i].xp, characterArray[i].level);
           // Debug.Log(SliderValue);
        }
}

    void dumpText(int i, string characterName, string aiName, ushort atk, ushort def, ushort spd, ushort hp, byte fAff, byte wAff, byte eAff, byte aAff, byte xp, byte level)
    {

        
        TextField = TextBox[i].GetComponent<Text>();
        TextField.text = characterName + "\n-----------------\n" +
            "Level "+level+" "+aiName+"\t("+xp+" XP)\n"+
            "Atk: " + atk + "\t\tF:AFF: " + fAff + "\n" +
             "Def: " + def + "\t\tE:AFF: " + eAff + "\n" +
              "Spd: " + spd + "\t\tW:AFF: " + wAff + "\n" +
               "Hp: " + hp + "\t\tA:AFF: " + aAff;



    }

}




