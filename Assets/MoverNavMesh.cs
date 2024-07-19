using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera camTop;
    public Camera camDown;
    public NavMeshAgent agent;
    private Camera activeCam;
    void Start(){
        agent=GetComponent<NavMeshAgent>();
        activeCam = camTop;
        if(camTop==null){
            activeCam=Camera.main;
        }else{camDown=Camera.main;}
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (camTop.enabled)
                {
                    activeCam = camTop;
                }
                else
                {
                    activeCam = camDown;
                }
        }
        if (Input.GetMouseButton(0))
        {
            Ray ray = activeCam.ScreenPointToRay(Input.mousePosition);
            
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}