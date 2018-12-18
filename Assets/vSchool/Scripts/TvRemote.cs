using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TvRemote : MonoBehaviour {
    //initialisation de variables
    public float rayLength;
    public LayerMask layermask;
    public GameObject video;

    private VideoPlayer videoPlayer;

     
    // Use this for initialization
    void Start () {
        //assignation du composant video
        videoPlayer = video.GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update ()
    { 
    RaycastHit hit;
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit, rayLength, layermask))
            {
            //Debug.Log(hit.collider);
            //si le collider touché est bien celui de la TV
            if (hit.collider == video.GetComponent<Collider>())
                {
                    playorPause();
                }
            }
	}
    void playorPause()
    {
        //detection de clics
        if (Input.GetMouseButtonDown(0))
        {
            //Pause si la video est deja entrain de jouer 
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
            //sinon play
            else
            {
                videoPlayer.Play();
            }
        }
    }
}
