using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour {

    public Hashtable personalDetails = new Hashtable();

    //HW Dictionaries
    public Hashtable superHeroes = new Hashtable();
    public Hashtable destinyWeps = new Hashtable();
    public Hashtable exoticArmor = new Hashtable();
    public Hashtable progLangs = new Hashtable();
    public Hashtable dmgType = new Hashtable();
	
	void Start () {

        //From Class
        personalDetails.Add("firstName", "Greg");
        personalDetails.Add("lastName", "Lukosek");
        personalDetails.Add("gender", "male");
        personalDetails.Add("isMarried", true);
        personalDetails.Add("age", 29);

        //HW Dictionaries
        superHeroes.Add("Best", "Superman");
        superHeroes.Add("Second Best", "Green Lantern");
        superHeroes.Add("Third Best", "Flash");
        superHeroes.Add("Last", "Batman");
        superHeroes.Add("hasDied", true);

        destinyWeps.Add("wepType", "Rocket");
        destinyWeps.Add("wepDmg", "Splash");
        destinyWeps.Add("isExotic", true);
        destinyWeps.Add("lightLvl", "650");

        exoticArmor.Add("Helmet", "Celestial NightHawk");
        exoticArmor.Add("Chest", "Raiden FLux");
        exoticArmor.Add("Gauntlet", "Liar's Handshake");
        exoticArmor.Add("Leg", "Raidiant Dance Machines");

        progLangs.Add("isCompiled", true);
        progLangs.Add("isCompiled", false);
        progLangs.Add("lowLevel", "Assembly");
        progLangs.Add("lowLevel", "ISA");
        progLangs.Add("Interpreter", 3);

        dmgType.Add("isKinetic", true);
        dmgType.Add("isExotic", false);
        dmgType.Add("Falloff", 25);
        dmgType.Add("Falloff", 200);
        dmgType.Add("Burn", "Arc");
        dmgType.Add("Burn", "Solar");
        dmgType.Add("Burn", "Void");
        dmgType.Add("isSorrow", true);


	}

}
