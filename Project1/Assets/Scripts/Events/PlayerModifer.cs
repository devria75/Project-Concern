using UnityEngine;
using System.Collections;

public class PlayerModifer : MonoBehaviour {

    
    [SerializeField]
    private float speedIncrease = 1f;
    [SerializeField]
    private float speedDecrease = 1f;
    [SerializeField]
    private float visionDimIncrease = .15f;
    [SerializeField]
    private float visionDimDecrease = -.15f;
    [SerializeField]
    private float beggerSpeedModifier = 4f;

    private Movement mov;
    private VisionEffect vision;
    private helpPerson help;
    private bool ignoreDebuff = false;
    private bool ignoreBuff = false;
    private HelpPersonMovement movement;
    private PlayerHealth health;
    public SpawnCrowd spawn;

    void Start()
    {
        vision = Camera.main.GetComponent<VisionEffect>();
        help = transform.parent.gameObject.GetComponent<helpPerson>();
        movement = transform.parent.gameObject.GetComponent<HelpPersonMovement>();
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
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
                if (ignoreBuff) return;
                if (help.getHelpStatus())
                {
                    mov.addSpeed(speedIncrease);
                    vision.addVision(visionDimDecrease);
                    spawn.Decreaserate();
                    health.updateHealth(1);
                    ignoreBuff = true;
                }
                else if(!help.getHelpStatus())
                {
                    if (ignoreDebuff) return;
                    vision.addVision(visionDimIncrease);

                    movement.setSpeed(Mathf.Clamp(beggerSpeedModifier + movement.getSpeed(), 0, 10));
                   
                    spawn.IncreaseSpawnRate();

                    

                    if (speedDecrease > 0)
                    {
                        mov.addSpeed(-speedDecrease);

                    }
                    else
                    {
                        mov.addSpeed(speedDecrease);
                    }

                    health.updateHealth(-1);

                    if (!GetComponent<ShyAway>().enabled)
                        GetComponent<ShyAway>().enabled = true;
                    ignoreDebuff = true;
                }
            }
        }
    }
}
