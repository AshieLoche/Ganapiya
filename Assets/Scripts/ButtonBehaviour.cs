using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Ganapiya
{
    public class ButtonBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        private Image _image;

        void Start()
        {
            _image = GetComponent<Image>();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _image.fillCenter = true;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _image.fillCenter = false;
        }
    }
}