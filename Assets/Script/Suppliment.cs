using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suppliment : MonoBehaviour
{
   [SerializeField] Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   private void OnTriggerStay(Collider other)
   {
      if (Input.GetKey(KeyCode.E) && other.tag == "Player")
      {
         movement.gas = 100;
      }
   }
}
