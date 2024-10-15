using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{

    public int scoreTracker;

    [SerializeField] CharacterMovement CharacterMovement;

    public static ScoreTracker Instance;

    
    void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTracker = CharacterMovement.score;
    }
}
