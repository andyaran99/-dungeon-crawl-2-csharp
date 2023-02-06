using TMPro;
using UnityEngine;
using DungeonCrawl.Core;

namespace Assets.Source.Core
{
    /// <summary>
    ///     Class for handling text on user interface (UI)
    /// </summary>
    public class UserInterface : MonoBehaviour
    {
        
        public enum TextPosition : byte
        {
            TopLeft,
            TopCenter,
            TopRight,
            MiddleLeft,
            MiddleCenter,
            MiddleRight,
            BottomLeft,
            BottomCenter,
            BottomRight
        }

        /// <summary>
        ///     User Interface singleton
        /// </summary>
        public static UserInterface Singleton { get; private set; }

        private TextMeshProUGUI[] _textComponents;
        public GameObject inventoryMenu;
        private DungeonCrawl.Core.GameManager gameManager = new DungeonCrawl.Core.GameManager();

        private void Start()
        {
            inventoryMenu.gameObject.SetActive(false);
        }

        public void Update()
        {
            InventoryControl();
        }

        private void InventoryControl()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (gameManager.isPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }

        public void Pause()
        {
            inventoryMenu.gameObject.SetActive(true);
            Time.timeScale = 0.0f;
            gameManager.isPaused = true;
        }

        public void Resume()
        {
            inventoryMenu.gameObject.SetActive(false);
            Time.timeScale = 1.0f;
            gameManager.isPaused = false;
        }

        private void Awake()
        {
            if (Singleton != null)
            {
                Destroy(this);
                return;
            }
            
            Singleton = this;

            _textComponents = GetComponentsInChildren<TextMeshProUGUI>();
        }

        /// <summary>
        ///     Changes text at given screen position
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textPosition"></param>
        public void SetText(string text, TextPosition textPosition)
        {
            _textComponents[(int) textPosition].text = text;
        }
    }
}
