using UnityEngine;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;

public class AutomaticDoor : MonoBehaviour
{
    private const float TIMEOPEN=2f;
    private const float TIMECLOSE = 5F;

    private IEnumerator OpenDoorAnim()
    {
        transform.DOLocalRotate(new Vector3(-90, 90, 0), TIMEOPEN);
        yield return new WaitForSeconds(TIMECLOSE);
        transform.DOLocalRotate(new Vector3(-90, 0, 0), TIMEOPEN);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 2)
        {
            StartCoroutine(OpenDoorAnim());
           
        }
    }
}
