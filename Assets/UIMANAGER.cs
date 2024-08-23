using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMANAGER : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnButtonGamePressed(string value)
    {
        GameManager.Instance.changescene(value);
    }

}
