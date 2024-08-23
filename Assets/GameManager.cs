using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float score = 0;
    public int lives = 3;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            changescene("Game");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            changescene("Menu");
        }
    }
    public void changescene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
