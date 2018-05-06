using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDButtons : MonoBehaviour {

    [System.Serializable] //Para conseguir controlar pelo Inspector
    public class Colorization
    {
        public string _name;
        public Color _color;
    }
    public List<Colorization> _colors;

    public ControlHeight ct;
    public ControlHeightEmails ctE;

    public TopLabel _header;

    public GameObject container_contacts; //são os contatos da parte de mensagens
    public GameObject container_galery;
    public GameObject container_musicPlayer;
    public GameObject container_notes;
    public GameObject container_preferences;
    public GameObject container_agenda; //são os contatos do telefone
    public GameObject container_vnus;
    public GameObject container_email;


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
       if (container_vnus != null)
            container_vnus.SetActive(false);
       if (container_email != null)
            container_email.SetActive(false);
       if (container_agenda != null)
            container_agenda.SetActive(false);
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
                if (container_notes == null)
                    return;
                container_notes.SetActive(false);
                break;

            case 2:
                if (container_musicPlayer == null)
                    return;
                container_musicPlayer.SetActive(false);
                break;

            case 3:
                if (container_preferences == null)
                    return;
                container_preferences.SetActive(false);
                break;

            case 4:
                if (container_galery == null)
                    return;
                container_galery.SetActive(false);             
                break;

            case 5:
                if (container_email == null)
                    return;
                container_email.SetActive(false);
                break;

            case 6:
                if (container_vnus == null)
                    return;
                container_vnus.SetActive(false);
                break;

            case 7:
                if (container_agenda == null)
                    return;
                container_agenda.SetActive(false);
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
        _header._image.color = _colors.Find(x => x._name == "MessagesHeader_Color")._color;
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(0);
        });

        if (container_contacts == null)
            return;
        //Debug.LogWarning("Não foi encontrado nenhum objeto no inspector do messagens");
        container_contacts.SetActive(true);

        ct.ChangeContactsHeight();
    }

    public void MusicPlayer ()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Music Player";
        _header._image.color = _colors.Find(x => x._name == "MusicPlayerHeader_Color")._color;
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(2);
        });

        if (container_musicPlayer == null)
            return;

        container_musicPlayer.SetActive(true);
    }

    public void Preferences ()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Preferencias";
        _header._image.color = _colors.Find(x => x._name == "PreferencesHeader_Color")._color;
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(3);
        });

        if (container_preferences == null)
            return;

        container_preferences.SetActive(true);
    }

    public void Notes ()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Notas";
        _header._image.color = _colors.Find(x => x._name == "NotesHeader_Color")._color;
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
        _header._image.color = _colors.Find(x => x._name == "GaleryHeader_Color")._color;
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(4);
        });

        if (container_galery == null)
            return;

        container_galery.SetActive(true);
    }

    public void Vnus()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Vnus";
        _header._image.color = _colors.Find(x => x._name == "VnusHeader_Color")._color;
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(6);
        });

        if (container_vnus == null)
            return;

        container_vnus.SetActive(true);
    }

    public void Agenda()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Contacts";
        _header._image.color = _colors.Find(x => x._name == "AgendaHeader_Color")._color;
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(7);
        });

        if (container_agenda == null)
            return;

        container_agenda.SetActive(true);
    }

    public void Email()
    {
        _header.gameObject.SetActive(true);
        _header._name.text = "Email";
        _header._image.color = _colors.Find(x => x._name == "EmailHeader_Color")._color;
        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate {
            CloseApp(5);
        });

        if (container_email == null)
            return;

        container_email.SetActive(true);

        ctE.ChangeEmailHeight();
    }

    #endregion
}
