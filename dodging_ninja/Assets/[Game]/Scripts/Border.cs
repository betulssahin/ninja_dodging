using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Border : MonoBehaviour
{

    /*float health = 100.0f;
    float current_health = 100.0f;
    public Image health_heart;
*/


     private void OnCollisionEnter(Collision collision){
         if(collision.gameObject.tag == "obstacle"){
            Destroy(collision.gameObject);
            
            /*float random = Random.Range(-7.5f, 7.5f);
            collision.gameObject.transform.position = new Vector3(random, 1,-5);
            */

            /*current_health -= 33.3f;
            health_heart.fillAmount = current_health / health;*/
    }

   }
}
