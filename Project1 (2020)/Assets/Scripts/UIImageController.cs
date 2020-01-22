using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class UIImageController : MonoBehaviour
{
   private Image img;

   private void Awake()
   {
      img = GetComponent<Image>();
   }

   public void UpdateImage(FloatData data)
   {
      img.fillAmount = data.value;
   }
}
