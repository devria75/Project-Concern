using UnityEngine;
using System.Collections;

public class PlayerModifer : MonoBehaviour {

    [SerializeField]
    private helpPerson help;
    [SerializeField]
    private float speedIncrease = 1f;
    [SerializeField]
    private float speedDecrease = 2f;
    [SerializeField]
    private float visionDimIncrease = .15f;
    [SerializeField]
    private float visionDimDecrease = -.10f;


    private Movement mov;
    private VisionEffect vision;

    public Spawner spawn;

    void Start()
    {
        vision = Camera.main.GetComponent<VisionEffect>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            mov = other.GetComponent<Movement>();
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            if(help != null)
            {
                if (help.getHelpStatus())
                {
                    mov.addSpeed(speedIncrease);
                    vision.addVision(visionDimDecrease);
                    spawn.DecreaseSpawnRate();
                }
                else
                {
                    vision.addVision(visionDimIncrease);
                    spawn.IncreaseSpawnRate();

                    if (speedDecrease > 0)
                    {
                        mov.addSpeed(-speedDecrease);
                        
                    }
                    else
                    {
                        mov.addSpeed(speedDecrease);
                    }
                    
                }
            }
            else
            {
                Debug.Log("You forgot to add the help script to the player modifer script.");
            }
        }
    }
}
