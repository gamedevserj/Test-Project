using MyNamespace;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MenusManager : MonoBehaviour
{
    [SerializeField] private Menu mainMenu;
    [SerializeField] private Menu optionsMenu;
    [SerializeField] private Menu audioOptionMenu;

    private Dictionary<MenuType, Menu> menus = new();
    private MenuType activeMenu;

    public static MenusManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            DestroyImmediate(this);
            return;
        }

        menus.Add(MenuType.MainMenu, mainMenu);
        menus.Add(MenuType.Options, optionsMenu);
        menus.Add(MenuType.Audio, audioOptionMenu);
        activeMenu = MenuType.MainMenu;

        foreach (var menu in menus)
        {
            menu.Value.Initialize();
        }

        menus[activeMenu].Switch(true);

        Instance = this;
        DontDestroyOnLoad(this);
    }

    public void SwitchMenu(MenuType menu)
    {
        var active = menus[activeMenu];
        active.Switch(false);
        var newMenu = menus[menu];
        newMenu.Switch(true);
        activeMenu = menu;
    }
}
