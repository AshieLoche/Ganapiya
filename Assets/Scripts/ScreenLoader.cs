using UnityEngine;

namespace Ganapiya
{
    public enum Screen
    {
        MainMenu,
        SignUp,
        LogIn,
        Subscribe
    }

    public class ScreenLoader : SingletonBehaviour<ScreenLoader>
    {
        [Header("Screens")]
        [SerializeField] private GameObject _mainMenuScreen;
        [SerializeField] private GameObject _signUpScreen;
        [SerializeField] private GameObject _logInScreen;
        [SerializeField] private GameObject _subscribeScreen;

        protected override void Awake()
        {
            base.Awake();
            LoadScreen(Screen.MainMenu);
        }

        public void LoadScreen(Screen screen)
        {
            _mainMenuScreen.SetActive(screen == Screen.MainMenu);
            _signUpScreen.SetActive(screen == Screen.SignUp);
            _logInScreen.SetActive(screen == Screen.LogIn);
            _subscribeScreen.SetActive(screen == Screen.Subscribe);
        }
    }
}