using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDButtons : MonoBehaviour {

    public ControlHeight ct;

    public TopLabel _header;

    public GameObject container_contacts;
    public GameObject container_galery;
    public GameObject container_musicPlayer;
    public GameObject container_notes;
    public GameObject container_preferences;

    void Start ()
    {
        if (_header != null)
            _header.gameObject.SetActive(false);
        if (container_galery != null)
            container_galery.SetActive(false);
        if (container_contacts != null)
            container_contacts.SetActive(false);
        if (container_musicPlayer != null)
            container_musicPlayer.SetActive(false);
        if (container_notes != null)
            container_notes.SetActive(false);
        if (container_preferences != null)
            container_preferences.SetActive(false);
    }

    public void CloseApp (int appToClose)
    {
        _header._backButton.onClick.RemoveAllListeners();

        switch (appToClose)
        {
            case 0:
                if (container_contacts == null)
                    return;
                container_contacts.SetActive(false);
                break;
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            default:
                Debug.LogWarning("App inexistente.");
                break;
        }

		_header.gameObject.SetActive(false);
    }

    #region Button Functions

    public void Messages ()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Mensagens";
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(0);
        });

        if (container_contacts == null)
            return;

        container_contacts.SetActive(true);

        ct.ChangeContactsHeight();
    }

    public void MusicPlayer ()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Music Player";
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(4);
        });

        if (container_musicPlayer == null)
            return;

        container_musicPlayer.SetActive(true);
    }

    public void Preferences ()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Preferencias";
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(2);
        });

        if (container_preferences == null)
            return;

        container_preferences.SetActive(true);
    }

    public void Notes ()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Notas";
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(1);
        });

        if (container_notes == null)
            return;

        container_notes.SetActive(true);
    }

    public void Galery ()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Galeria";
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(3);
        });

        if (container_galery == null)
            return;

        container_galery.SetActive(true);
    }

    #endregion
}
