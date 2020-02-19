
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour

{
private Image imageObj;
public float ImageType; 
private void Start()
    {
        imageObj = GetComponent<Image>();
        ImageType;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
