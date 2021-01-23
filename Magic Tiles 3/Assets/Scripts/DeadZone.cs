using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DeadZone : MonoBehaviour
{
    public static bool GameisPaused = false;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "DeathZone")
        {
            if(other.tag == "Blue")
        {
            TimedSpawn timedSpawn = GameObject.Find("Spawner").GetComponent<TimedSpawn>();
            if(timedSpawn != null)
            {
                timedSpawn.StopSpawning();
            }
            //Time.timeScale = 0;
        }
        }
    } 
    public GameObject PasueMenuUI;
        void Pause ()
    {
        PasueMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }
}
