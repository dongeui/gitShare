using UnityEngine;
using UnityEngine.UI;

public class CarColorChange : MonoBehaviour
{
    public Material mat = null;

    public void ColorChange(Image img)
    {
        mat.color = img.color;
    }
}