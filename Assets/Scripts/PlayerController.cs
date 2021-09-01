using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //variables
    [Tooltip("Velocidad actual del vehículo")]
    [SerializeField]
    [Range(0, 20)] 
    private float speed = 5.0f ;
    public float turn;
    public float jostikHorizontal;
    public float jostikVertical;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jostikHorizontal = Input.GetAxis("Horizontal");
        jostikVertical = Input.GetAxis("Vertical");

        //this.transform.Translate(0,0,1);
        //this.transform.Translate(Vector3.forward);
        //this.transform.Translate(Vector3.back);

        // Time.deltaTime es la cantidad de tiempo que ha pasado de un frame a otro

        //Formula la la velocidad 
        //Epacio = S0 + Velocidad por tiempo(direccion)


            this.transform.Translate(this.speed * Time.deltaTime * Vector3.forward * jostikVertical);


      
        if (jostikVertical != 0)
        {
            if (jostikVertical > 0)
            {
                this.transform.Rotate(this.turn * Time.deltaTime * Vector3.up * jostikHorizontal);
            }
            else
            {
                this.transform.Rotate(this.turn * Time.deltaTime * Vector3.up * jostikHorizontal * -1);
            }
        }
       
      
        
    }
}
