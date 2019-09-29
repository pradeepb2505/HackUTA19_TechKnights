using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_on : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }
    private void OnMouseDown()
    {
        First.action("/23/on");
    }
}
