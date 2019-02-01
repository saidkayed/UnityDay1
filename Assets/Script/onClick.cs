using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClick : MonoBehaviour
{
    public string _printText;
    public GameObject TestCube;
    public int antal;
    public AudioClip gunshot; //set this in ispector with audiofile
    public AudioClip kabom; //set this in ispector with audiofile

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void printText()
    {
        print(_printText);
    }


    //sådan hiver man fat i komponenter fra unity
    public void playSound()
    {
        GetComponent<AudioSource>().clip = gunshot;
        GetComponent<AudioSource>().Play();
    }
    public void addObject()
    {
        for (int i = 0; i < antal; i++) {
            Instantiate(TestCube, new Vector3(3, 5, 0), Quaternion.identity);

        }
    }

    public void boom()
    {

        GetComponent<AudioSource>().clip = kabom;
        GetComponent<AudioSource>().Play();
        for (int i = 0; i < 100; i++)
        {
           GameObject clone = Instantiate(TestCube, new Vector3(3, 5, 0), Quaternion.identity);
            Destroy(clone, 5);
        }

       
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
