using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour{
    [SerializeField]
    private float nilaiSekarang;
    [SerializeField]
    private float nilaiKecepatan;

    void Start(){
    }

    void Update(){
        if(nilaiSekarang < 100){
			nilaiSekarang += nilaiKecepatan * Time.deltaTime;
			Debug.Log ((int)nilaiSekarang);
		}
		else{
			Application.LoadLevel("LoadingBar");
		}
	}
}
