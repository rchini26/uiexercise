using UnityEngine;
using System.Collections.Generic;
using Core.Singleton;

namespace Screens
{
public class ScreenManager : Singleton<ScreenManager>
{
    public List<ScreenBase> screenBases;
    public ScreenType startScreen = ScreenType.Main_Menu_Panel;

    private ScreenBase _currentScreen;
    
    private void Start()
    {
        HideAll();
        ShowByType(startScreen);
    }
    
    public void ShowByType(ScreenType screenType)
    {
        if (_currentScreen != null) _currentScreen.Hide();
        
        var nextScreen = screenBases.Find(screen => screen.screenType == screenType);
        
        nextScreen.Show();
        _currentScreen = nextScreen;
    }

    public void HideAll()
    {
        screenBases.ForEach(screen => screen.Hide());
    }
}
}