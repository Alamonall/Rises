﻿using UnityEngine;
using System.Collections;

public class EnemyTwo : IJudje {
	void Start(){
		MaxHealt = 100;
		MaxMana = 200;
		Mana = MaxMana;
		Health = MaxHealt;
		GStrength = 5;
		Name = "Goblin2";
		GEndurance = 4;
		GIntelligence = 8;
		GAgility = 6;
		GMagic = 6;
		GLucky = 5;
		ActionPoint = 3;
	}
	public void Display(){
		Debug.Log(" My Name = "  + Name);
	}
}
