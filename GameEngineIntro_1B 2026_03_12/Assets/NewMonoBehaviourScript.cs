using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public string playername;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("æ»≥Á«œººø‰?" + playername);
        Debug.LogError("æ»≥Á«œººø‰?");
        Debug.LogWarning("æ»≥Á«œººø‰?");

    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("12345");
    }
}
