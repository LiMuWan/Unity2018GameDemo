using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalStorage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("account", "123456");
        PlayerPrefs.SetString("password", "123456");
        PlayerPrefs.SetInt("stage", 2);
        PlayerPrefs.SetFloat("hp", 1200f);
        PlayerPrefs.Save();

        if(PlayerPrefs.HasKey("account"))
        {
            Debug.Log("账户已存在");
        }
        else
        {
            Debug.Log(PlayerPrefs.GetString("account"));
            Debug.Log(PlayerPrefs.GetString("password"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}
