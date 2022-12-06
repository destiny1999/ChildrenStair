using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBackgroundControler : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] bool needCreate = false;
    //[SerializeField] GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (needCreate)
        {
            GameManager.Instance.CreateGameBackground();
            //gameManager.GetComponent<GameManager>().CreateGameBackground();
        }
    }
}
