using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss{
    private int hp = 100;      //体力
    private int power = 25;　  //攻撃力　
    private int mp = 53;      // MP

    //　攻撃用の関数
　　public void Attack(){
           Debug.Log(this.power + "のダメージを与えた");
    }

    // 　防御用の関数
    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        //残りHPを減らす
        this.hp -= damage;
    }

    //   Magic用関数
    public void Magic(int MPconsume) {
        
        
        if (mp > MPconsume){
            // mpが足りる時,残りのMPを減らす
            this.mp -= MPconsume;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }else{
            // mpが足りない時
            Debug.Log("MPが足りないため魔法が使えない");
        }
        
    }
    }

public class Test:MonoBehaviour {

    void Start(){
        // 配列を初期化する
        int[] points = { 10, 20, 30, 40, 50 };

        //HW1 for文を使い、配列の各要素の値を順番に表示
        for (int i = 0; i < points.Length; i++){
            Debug.Log(points[i]);

            //Debug.Log(points.Length);
        }

        //HW2 for文を使い、配列の各要素の値を逆順に表示
        for (int i = points.Length -1; i >= 0; i--){
            Debug.Log(points[i]);
        }
        // HW3 発展課題
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // Magic用の関数を呼び出す,11回ループする
        for (int i=1; i<=11; i++)
        lastboss.Magic(5);

    }
    //  Update is called once per frame 

    void Update() { 
    
    }
}




