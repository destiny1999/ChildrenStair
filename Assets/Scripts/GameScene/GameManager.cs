using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameBackground;
    public static GameManager Instance;
    [SerializeField] Transform createPositionTransform;
    Vector3 targetPosition;
    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = createPositionTransform.position;
        //gameBackground = GameObject.Find("Game Background");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateGameBackground() 
    {
        GameObject newGameBackground = Instantiate(gameBackground);
        newGameBackground.transform.position = targetPosition;
    }
}
