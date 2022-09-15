using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



    

public class Growth : MonoBehaviour
{
    public  Text coinplus;

    private int score = 0;
    public GameObject BodyPrefabs;
    

    public List<GameObject> BodyParts = new List<GameObject>();

    private List<Vector3> _position_history = new List<Vector3>();
    private int Gap = 10;
     float BodySpeed = 10;
    
    // Start is called before the first frame update
    void Start()
    {

        coinplus.text = "0";

    }

   

    // Update is called once per frame
    void Update()
    {
      _position_history.Insert(0,transform.position);
      int index = 1;
      foreach (var body in BodyParts)
      {
          Vector3 point = _position_history[(int)Math.Min(index * Gap,_position_history.Count-1)];
          Vector3 move_direction = point - body.transform.position;
          body.transform.position += move_direction * (BodySpeed * Time.deltaTime);
          body.transform.LookAt(point);
          index++;

      }

    }

    private void GrowSnake()
    {
        GameObject body = Instantiate(BodyPrefabs);
        BodyParts.Add(body);
        
    }

    
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
            
            Destroy(other.gameObject, .1f);
            score += 10;
            coinplus.text = score + "";
            GrowSnake();
            PlayerPrefs.SetInt("Score",score);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");

    }
}
