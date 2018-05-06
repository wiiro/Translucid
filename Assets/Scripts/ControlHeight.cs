using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlHeight : MonoBehaviour {

    public RectTransform _myHeight;
    public RectTransform[] messages;
    float _height = 0;

    public void ChangeMessagesHeight ()
    {
		_height = 0;
		for (int i = 0; i < messages.Length; i++)
        {
            _height += messages[i].rect.height + 10;
        }

		if (_height < Screen.height) {
			_myHeight.sizeDelta = new Vector2(Screen.width, Screen.height - 200);
		} else {
			_myHeight.sizeDelta = new Vector2(Screen.width, _height);
		}

		StartCoroutine (Change ());
	}

	public void ChangeContactsHeight ()
	{
		_height = 0;
		for (int i = 0; i < messages.Length; i++)
		{
			_height += messages[i].rect.height + 30;
		}

		if (_height < Screen.height) {
			_myHeight.sizeDelta = new Vector2(Screen.width, Screen.height - 250);
		} else {
			_myHeight.sizeDelta = new Vector2(Screen.width, _height);
		}

		StartCoroutine (Change ());
	}


	IEnumerator Change () {
		yield return null;
		_myHeight.localPosition = Vector3.zero;
	}

  
}
