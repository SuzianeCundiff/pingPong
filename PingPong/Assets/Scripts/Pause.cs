using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool emPause;
    public GameObject painel;

    private void Start()
    {
        painel.SetActive(false);
        emPause = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && emPause == false)
        {
            emPause = true;
            Time.timeScale = 0;
            painel.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && emPause == true)
        {
            emPause = false;
            Time.timeScale = 1;
            painel.SetActive(false);
        }
    }
}
