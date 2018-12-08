﻿using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
    // トリガーとの接触時に呼ばれるコールバック
    private void OnTriggerEnter(Collider hit)
    {

        //接触対象はplayerタグですか？
        if (hit.CompareTag("Player"))
        {
            //何らかの処理

            //このコンポーネントを持つGameObjectを破棄する
            Destroy(gameObject);

           



        }     

    }
   


}
