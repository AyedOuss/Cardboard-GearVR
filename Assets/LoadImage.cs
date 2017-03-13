using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadImage : MonoBehaviour
{


    public string url = "http://www.roadtovr.com/wp-content/uploads/2014/09/Venice.Still001.jpeg";
    Texture2D img;
    public GameObject sphere;
    // Use this for initialization
    void Start()
    {

        StartCoroutine(LoadImg());
    }
    IEnumerator LoadImg()
    {

        yield return 0;
        WWW imgLink = new WWW(url);
        yield return imgLink;
        img = imgLink.texture;
        sphere.GetComponent<Renderer>().material.mainTexture = img;

    }
    // Update is called once per frame

}
