using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailControl : MonoBehaviour
{

    public HUDButtons hudButtons;

    public TopLabel _header;

    public ControlHeightEmails ctE;

    public GameObject container_emails;

    public Transform[] container_email;


   int selectedEmail = 0;                    //email selecionado

    string selectedMessage = "";

    void Start()
    {
        for (int i = 0; i < container_email.Length; i++)
        {
            container_email[i].gameObject.SetActive(false);
        }
    }

    public void SelectedEmail(int email)
    {
        selectedEmail = email;

        _header._backButton.onClick.RemoveAllListeners();
        _header._backButton.onClick.AddListener(delegate
        {
            CloseMessages();
        });

        for (int i = 0; i < container_email.Length; i++)
        {
            if (i == email)
            {
                container_email[i].gameObject.SetActive(true);
            }
            else
            {
                container_email[i].gameObject.SetActive(false);
            }
        }


        container_emails.SetActive(true);

        ctE.ChangeEmailHeight();
    }

    void CloseMessages()
    {
        _header._backButton.onClick.RemoveAllListeners();
        container_emails.SetActive(false);
        _header._backButton.onClick.AddListener(delegate {
            hudButtons.CloseApp(0);
        });
    }
}
