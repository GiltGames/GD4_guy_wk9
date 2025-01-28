using UnityEngine;

public class MBSDoor : MonoBehaviour
{
    [SerializeField] Transform gAura;
    [SerializeField] bool isNear;
    [SerializeField] Animator anim;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isNear)
        {

            if (Input.GetMouseButtonDown(0))

            {
                anim.SetTrigger("Change");
               
                
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Debug.Log(Input.mousePosition);



                RaycastHit hit;


                Physics.Raycast(ray, out hit);

                Debug.Log("Hits " + hit.transform.name);

               // Debug.DrawRay(ray, transform.forward);


                if (hit.transform.tag == "Aura")
                {

                  

                }
               

            }




        }



    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")

        {
            gAura.gameObject.SetActive(true);
            isNear = true;

        }


    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")

        {
            gAura.gameObject.SetActive(false);
            isNear = false;

        }


    }

}
