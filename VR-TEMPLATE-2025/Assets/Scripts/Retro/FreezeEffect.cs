using System.Collections;
using UnityEngine;

public class FreezeEffect : MonoBehaviour
{
    private const float DEFAULT_TIME_SCALE = 1f;
    private const float FREEZE_TIME_SCALE = 0.5f;
    private const float FREEZE_DURATION = 5f;

    [Header("Emission Colors (HDR)")]
    [SerializeField] private Color freezeColor = Color.cyan;
    [SerializeField] private Color secondaryFreezeColor = Color.white;
    [SerializeField] private float emissionIntensity = 4f;

    private Color[] originalEmissionColors;
    private Coroutine freezeRoutine;

    private static readonly int EmissionColorID = Shader.PropertyToID("_EmissionColor");

    private void Start()
    {
        Time.timeScale = DEFAULT_TIME_SCALE;
    }
    [ContextMenu("Freeze")]
    public void TriggerFreeze()
    {
        if (freezeRoutine != null)
            StopCoroutine(freezeRoutine);

        freezeRoutine = StartCoroutine(FreezeRoutine());
    }

    private IEnumerator FreezeRoutine()
    {
        Time.timeScale = FREEZE_TIME_SCALE;

        ApplyFreezeEmission();

        yield return new WaitForSecondsRealtime(FREEZE_DURATION);

        RestoreOriginalEmission();
        Time.timeScale = DEFAULT_TIME_SCALE;

        freezeRoutine = null;
    }


    private void ApplyFreezeEmission()
    {
        LoaderController.Instance.ApplyEffectColor(freezeColor, secondaryFreezeColor);
    }

    private void RestoreOriginalEmission()
    {
        LoaderController.Instance.ApplySceneColors();
    }
}
