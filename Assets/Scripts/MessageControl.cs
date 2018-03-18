using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageControl : MonoBehaviour {

    public HUDButtons hudButtons;

	public TopLabel _header;

    public ControlHeight ct;

    public GameObject container_contacts;
    public GameObject container_all_messages;

    public MessageText player_message;          //prefab de mensagens do jogador
    public MessageText ia_message;              //prefab de mensagens da IA
    public Transform[] container_messages;      //Container onde spawna as mensagens

    int selectedContact = 0;                    //contato selecionado

    string selectedMessage = "";

    void Start ()
    {
        for (int i = 0; i < container_messages.Length; i++)
        {
            container_messages[i].gameObject.SetActive(false);
        }
    }

    public void SelectContact(int contact)
    {
        selectedContact = contact;

		_header._backButton.onClick.RemoveAllListeners();
		_header._backButton.onClick.AddListener(delegate
        {
            CloseMessages();
        });

        for (int i = 0; i < container_messages.Length; i++)
        {
            if (i == contact)
            {
                container_messages[i].gameObject.SetActive(true);
            } else
            {
                container_messages[i].gameObject.SetActive(false);
            }
        }

        container_all_messages.SetActive(true);

        ct.ChangeMessagesHeight();
    }

    void CloseMessages ()
    {
		_header._backButton.onClick.RemoveAllListeners();
		container_all_messages.SetActive(false);
		_header._backButton.onClick.AddListener(delegate {
			hudButtons.CloseApp (0);
		});
    }

    public void InputButton () {
        
    }

    public void SelectMessage ()
    {
        player_message._message.text = selectedMessage;

        Instantiate(player_message, container_messages[selectedContact]);

        StartCoroutine(IAMessage());
    }

    IEnumerator IAMessage ()
    {
        yield return new WaitForSeconds (Random.Range (0.5f, 1.0f));
        Instantiate(ia_message, container_messages[selectedContact]);
    }

}
