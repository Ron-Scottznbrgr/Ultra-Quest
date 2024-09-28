using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// generic parent class to all other character classes

public class battle_GenericCharacterClass :MonoBehaviour
{
    //byte 0-255
    public byte fAff, wAff, eAff, aAff;
    public byte level, xp;
    public byte atkGrowth, defGrowth, spdGrowth, hpGrowth;
    public byte spellSlots;

    //ushort 0-65535 
    public ushort atk, def, spd, hp;

    public string characterName, aiType;

    int rand;
    public string[] namesArray = { "Boco", "Deltia", "Ramza", "Emldor", "Ryuko", "Sato", "Cid", "Vincint", "Reeve", "Titan", "Grave" };
    public string[] aiArray = { "Medic", "Melee", "Ranged", "Enchanter", "Poisoner", "Coward" };


    GameObject Char1Field;
    Text generatedValues;

    private void Start()
    {
        /*
        generateValues();
        Char1Field = GameObject.Find("Char1");
        generatedValues = Char1Field.GetComponent<Text>();
        generatedValues.text = characterName + "\n-----------------\n" +
            "Atk: " + atk + "\t\tF:AFF: " + fAff + "\n" +
             "Def: " + def + "\t\tE:AFF: " + eAff + "\n" +
              "Spd: " + spd + "\t\tW:AFF: " + wAff + "\n" +
               "Hp: " + hp + "\t\tA:AFF: " + aAff;
               */
    }

    public void generateValues()
    {
        characterName = namesArray[(int)Random.Range(0f, (float)namesArray.Length)];
        aiType = aiArray[(int)Random.Range(0f, (float)aiArray.Length)];
        fAff = (byte)Random.Range(0f, 100f);
        wAff = (byte)Random.Range(0f, 100f);
        aAff = (byte)Random.Range(0f, 100f);
        eAff = (byte)Random.Range(0f, 100f);
        atk = (ushort)Random.Range(5f, 400f);
        def = (ushort)Random.Range(5f, 400f);
        spd = (ushort)Random.Range(5f, 400f);
        hp = (ushort)Random.Range(20f, 5000f);
    }

    public void retext()
    {
        /*
        Char1Field = GameObject.Find("Char1");
        generatedValues = Char1Field.GetComponent<Text>();
        generatedValues.text = characterName + "\n-----------------\n" +
            "Atk: " + atk + "\t\tF:AFF: " + fAff + "\n" +
             "Def: " + def + "\t\tE:AFF: " + eAff + "\n" +
              "Spd: " + spd + "\t\tW:AFF: " + wAff + "\n" +
               "Hp: " + hp + "\t\tA:AFF: " + aAff;
    */
    }


}
