using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlHeightEmails : MonoBehaviour {

    public RectTransform _EmailHeight;
    public RectTransform[] emails;
    float _heightE = 0;

    public void ChangeEmailHeight()
    {
        _heightE = 0;
        for (int i = 0; i < emails.Length; i++)
        {
            _heightE += emails[i].rect.height + 30;
        }

        if (_heightE < Screen.height)
        {
            _EmailHeight.sizeDelta = new Vector2(Screen.width, Screen.height - 200);
        }
        else
        {
            _EmailHeight.sizeDelta = new Vector2(Screen.width, _heightE);
        }

        StartCoroutine(ChangeEmail());
    }

    IEnumerator ChangeEmail()
    {
        yield return null;
        _EmailHeight.localPosition = Vector3.zero;
    }
}
