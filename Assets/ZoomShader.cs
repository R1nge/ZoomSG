using UnityEngine;

public class ZoomShader : MonoBehaviour
{
    [SerializeField] private Material material;
    private Camera _camera;
    private static readonly int ObjectScreenPosition = Shader.PropertyToID("_ObjectScreenPosition");

    private void Awake() => _camera = Camera.main;

    private void Update()
    {
        Vector2 screenPixels = _camera.WorldToScreenPoint(transform.position);
        screenPixels = new Vector2(screenPixels.x / Screen.width, screenPixels.y / Screen.height);

        material.SetVector(ObjectScreenPosition, screenPixels);
    }
}