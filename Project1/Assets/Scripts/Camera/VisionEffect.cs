using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
[RequireComponent(typeof(VignetteAndChromaticAberration))]
public class VisionEffect : MonoBehaviour {

    [SerializeField]
    private float maxDimVision = .40f;
    private float visionLevel = 0f;

    private VignetteAndChromaticAberration dimmer;

	void Start () {
        dimmer = GetComponent<VignetteAndChromaticAberration>();
	}
	
	// Update is called once per frame
	void Update () {
        dimmer.intensity = visionLevel;

        Debug.Log("Vision level " + visionLevel);
	}

    public void addVision(float level)
    {
        visionLevel = Mathf.Clamp(visionLevel + level, 0, maxDimVision);
    }
}
