using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class LimitDrawer : MonoBehaviour
{
    [SerializeField]
    public float maxZPos;
    private bool _canCheck;
    [SerializeField]
    private Transform drawerTransform;

    void Update()
    {
        if (_canCheck)
            CheckZPos();
    }
    private void CheckZPos()
    {
        Vector3 posicaoAtual = drawerTransform.localPosition;
        if (posicaoAtual.z > maxZPos)
        {
            posicaoAtual.z = maxZPos;
            drawerTransform.localPosition = posicaoAtual;
            DisableGrab(false);
        }
        else
        {
            DisableGrab(true);
        }

    }
    private void DisableGrab(bool disable)
    {
        gameObject.GetComponent<XRGrabInteractable>().trackPosition = disable;
    }
    public void CanCheckPos(bool canCheck)
    {
        _canCheck = canCheck;
    }
}
