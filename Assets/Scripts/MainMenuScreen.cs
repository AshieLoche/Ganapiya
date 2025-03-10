using UnityEngine;
using UnityEngine.UI;

namespace Ganapiya
{
    public class MainMenuButtonsScreen : MonoBehaviour
    {
        [Header("Main Menu Buttons")]
        [SerializeField] private Button _signUpButton;
        [SerializeField] private Button _logInButton;
        [SerializeField] private Button _subscribeButton;

        void Awake()
        {
            _signUpButton.onClick.AddListener(() =>
                ScreenLoader.Instance.LoadScreen(Screen.SignUp)
            );
            _logInButton.onClick.AddListener(() =>
                ScreenLoader.Instance.LoadScreen(Screen.LogIn)
            );
            _subscribeButton.onClick.AddListener(() =>
                ScreenLoader.Instance.LoadScreen(Screen.Subscribe)
            );
        }
    }
}