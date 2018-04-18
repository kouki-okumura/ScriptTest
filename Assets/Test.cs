using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	public  int mp = 53;
	private int hp = 100;
	public int power = 25;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}
	public void Defence(int damage){
		Debug.Log (damage+"のダメージを受けた");
	    this .hp -= damage;
	}
	public void Magic(int number){
		if (mp >= number) {
			mp -= number ;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない");
		}
	}
			



	




	//public void Magic(int number){
	//	for (int i = 0;i< number ;i++){
	//		this.mp -= 5;
	//		Debug.Log ("魔法攻撃をした。残りMPは" + mp);
	//	}
	//	if(mp <5){
	//		Debug.Log ("MPが足りないため魔法が使えない");
	//	}
	//}
				
				
		

}



public class Test : MonoBehaviour {
	//void GoodBye(){
	//	Debug.Log ("GoodBye,UnityChan");
	//
	//void HelloName(int name){
	//	Debug.Log ("Hello" + name);
	//}
	//int Add( int a, int b, int c){
	//	int d = a + b + c;
	//	return d;
	//}
		
		
			

	// Use this for initialization
	void Start () {
		//Debug.Log ("Hello,World");
		// score;
		// = 150;
		//int a = 3;
		//int b = 4;
		//int c = a + b;
		//Debug.Log (c);
		//int money = 10;
		//if (money <= 50) {
		//	Debug.Log ("武器を売る");
		//} else　if (money >= 200) {
		//	Debug.Log ("武器を買う");
		//}else {
		//	Debug.Log("ポーションを買う");
	//}
		//int num = 10;
		//int val = (num == 1) ? -100 : 100;
		//Debug.Log (val);
		//int a =3;
		//if (a == 3){
		//	int b = 5;
		//	Debug.Log (b);
		//}
		//for (int i = 0; i < 10; i++) {
		//	Debug.Log (i);
		//}

		//string  [] points = new string[5];
		//points [0] = "apple";
		//points [1] = "orange";
		//points [2] = "banana";
		//points [3] =" melon";
		//points [4] = "sushi";
		//for (int  i = 0; i < 5; i++) {
		//	Debug.Log (points [i]);
		//}
		//int[] points = {30,20,50,10,80,15,60,100};
		//for (int i = 0; i < points.Length; i++) {
		//	Debug.Log (points [i]);
		//}
		//GoodBye();
		//HelloName (1);
		// num = Add(5,7,8);
		//Debug.Log (num);
		int [] array = new int[5] ;
		array [0] = 1;
		array [1] = 2;
		array [2] = 3;
		array [3] = 4;
		array [4] = 5;
		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}
		for (int i = 4; i > -1; i--) {
			Debug.Log (array [i]);
		}
		Boss lastboss = new Boss ();

		lastboss.Attack ();
		lastboss.Defence (3);
		for (int i = 0; i < 11; i++) {
			lastboss.Magic (5);
		}														
	}
	
	// Update is called once per frame
	void Update () {
			
	}
}

