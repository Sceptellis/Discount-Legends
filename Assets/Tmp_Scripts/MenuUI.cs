using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class MenuUI : MonoBehaviour
{

    [SerializeField] GameObject _loadingScreen;
    [SerializeField] GameObject _createRoomMenu;
    [SerializeField] GameObject _joinRoomMenu;
    [SerializeField] GameObject _titleScreenMenu;
    [SerializeField] GameObject _currentRoomMenu;
    [SerializeField] GameObject _joinOrCreateMenu;
    [SerializeField] TMP_Text _roomNameText; 
    private string _currentRoomName; 

    private GameObject[] menuList; 
    // Start is called before the first frame update
    void Start()
    {
        menuList = new GameObject[6] { _loadingScreen, _createRoomMenu, _joinRoomMenu, _titleScreenMenu, _currentRoomMenu, _joinOrCreateMenu };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetOtherMenuInactive(GameObject g)
    {
        foreach(GameObject o in menuList)
        {
            if(o != g)
            {
                o.SetActive(false);
            }
        }
    }
    public void OpenCurrentRoomMenu()
    {
        _currentRoomMenu.SetActive(true);
        SetOtherMenuInactive(_currentRoomMenu);
    }

    public void OpenTitleScreenMenu()
    {
        _titleScreenMenu.SetActive(true);
        SetOtherMenuInactive(_titleScreenMenu);
    }

    public void OpenJoinRoomMenu()
    {
        _joinRoomMenu.SetActive(true);
        SetOtherMenuInactive(_joinRoomMenu);
    }

    public void OpenCreateRoomMenu()
    {
        _createRoomMenu.SetActive(true);
        SetOtherMenuInactive(_createRoomMenu);
    }

    public void OpenLoadingScreen()
    {
        _loadingScreen.SetActive(true);
        SetOtherMenuInactive(_loadingScreen);
    }

    public void OpenJoinOrCreateScreen()
    {
        _joinOrCreateMenu.SetActive(true);
        SetOtherMenuInactive(_joinOrCreateMenu);
    }

    public void CreateRoomButton()
    {
        OpenCreateRoomMenu(); 
    }

    public void JoinRoomButton()
    {
        OpenJoinRoomMenu(); 
    }


    public void SetRoomName(string name)
    {
        _roomNameText.text = name; 
    }
}
