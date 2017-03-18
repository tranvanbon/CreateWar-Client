using UnityEngine;
using System.Collections;

public class AnnocementContents : MonoBehaviour {
	//private string url = "http://noah.cmge.com/cp/GameBulletin_Throne.html";
	//private string url = "http://221.229.162.251:8080/cp/GameBulletin_Throne.html";

/*#if UNITY_IOS
    #if SDK_ZSYIOS
        private string url = "http://221.229.162.251:8080/cp/AppleGameBulletin.html";
    #else
        private string url = "http://221.229.162.251:8080/cp/GameBulletin_Throne.html";
    #endif
#elif UNITY_ANDROID
	private string url = "http://221.229.162.251:8080/cp/1.2.6Android/GameBulletin.html";
#else
	private string url = "http://192.168.1.10:8080/cp/1.2.9Android/GameBulletin_Throne.html";
#endif*/
	private string url = "http://192.168.1.10/cp/1.2.9Android/GameBulletin_Throne.html";
    public UILabel annocementLabel;
	// Use this for initialization
	void Start () {
        StartCoroutine(ShowAnnocementContents());
	}

    IEnumerator ShowAnnocementContents()
    {
        Debug.Log("url------------------------------" + url);
        WWW www = new WWW(url);
        yield return www;
        annocementLabel.text = www.text;
    }
}
