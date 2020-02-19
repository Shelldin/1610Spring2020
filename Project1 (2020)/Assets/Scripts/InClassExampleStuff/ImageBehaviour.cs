
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]

public class ImageBehaviour : MonoBehaviour
{
    private Image imageObj;
    
    void Start()
    {
        imageObj = GetComponent<Image>();
    }

    
    void Update()
    {
        
    }
}
