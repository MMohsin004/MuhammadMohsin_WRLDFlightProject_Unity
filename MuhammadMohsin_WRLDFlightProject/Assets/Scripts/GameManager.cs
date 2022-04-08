using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Button ignition;
    [HideInInspector]
    public bool engineRunning;
    public GameObject helicopter;
    private Rigidbody rb;
    private Animation helicopterAnimation;
    private void Awake()
    {
        if (instance!=null)
        {
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        engineRunning = false;
        helicopterAnimation = helicopter.GetComponent<Animation>();
        rb = helicopter.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EngineStart()
    {
        ignition.gameObject.SetActive(false);
        engineRunning = true;
        helicopterAnimation.Play();
        rb.useGravity = false;
    }
}
