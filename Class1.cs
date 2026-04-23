using BepInEx;
using BepInEx.Unity.IL2CPP;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace NobetaWidescreenFix
{
    [BepInPlugin("com.widescreen.nobeta", "Nobeta Widescreen Fix", "1.0.0")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            Log.LogInfo("Nobeta Force Widescreen Fix loaded.");
            AddComponent<WidescreenController>();
        }
    }

    public class WidescreenController : MonoBehaviour
    {
        private int _lastSceneIndex = -1;
        private float _timer = 0f;

        public WidescreenController(System.IntPtr handle) : base(handle) { }

        void Start()
        {
            ApplyResolution();
        }

        void LateUpdate()
        {
            _timer += Time.deltaTime;

            // check for resolution change
            if (_timer > 5f)
            {
                if (Screen.width != Display.main.systemWidth || Screen.height != Display.main.systemHeight)
                {
                    ApplyResolution();
                }
                _timer = 0f;
            }

            // ui and camera fix
            var cameras = Camera.allCameras;
            float targetAspect = (float)Screen.width / Screen.height;

            for (int i = 0; i < cameras.Count; i++)
            {
                cameras[i].aspect = targetAspect;
            }

            // ui fix after scene change
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            if (currentSceneIndex != _lastSceneIndex)
            {
                FixCanvasScalers();
                _lastSceneIndex = currentSceneIndex;
            }
        }

        private void ApplyResolution()
        {
            // check host resolution
            int w = Display.main.systemWidth;
            int h = Display.main.systemHeight;

            if (Screen.width != w || Screen.height != h)
            {
                Screen.SetResolution(w, h, true);
                UnityEngine.Debug.Log($"[WidescreenFix] Re-applying resolution: {w}x{h}");
            }
        }

        private void FixCanvasScalers()
        {
            var scalers = UnityEngine.Object.FindObjectsOfType<CanvasScaler>();
            foreach (var s in scalers)
            {
                s.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            }
        }
    }
}
