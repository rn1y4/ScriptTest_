using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100;//体力
    private int power = 25;//攻撃力
    private int mp = 53;//マジックポイント

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log( this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log( damage + "のダメージを受けた");
        //残りHPを減らす
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic()
    {
        if(this.mp >= 5)
        {
            //残りMPを減らす
            mp = mp-5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }else{
            Debug.Log("MPが足りないため、魔法が使えない");
        }

    }

}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //配列の用意
        int[] array = {10,20,30,40,50};

        //配列の要素を表示
        for(int i = 0; i<array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        
        //配列の要素を逆から表示
        for(int j = array.Length-1; j>=0; j--)
        {
            Debug.Log(array[j]);
        }

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();

        //防御用の関数を呼び出す
        lastboss.Defence(3);

        //魔法攻撃用の関数を11回呼び出す
        for(int x = 0; x<11; x++){
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

