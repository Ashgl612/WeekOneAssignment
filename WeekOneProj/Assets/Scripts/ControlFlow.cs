using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public bool flag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (flag)
        {
            for (int x = 0; x<10; x++)
            {
                int y= (int)Mathf.Pow(2, x);
                Debug.Log($"the {x} power of two is {y}");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
