using System.Collections.Generic;
using UnityEngine;

public enum GameMode { None, Versus, Solo}
public class GameModeChosen
{
    public static GameMode SelectedMode;
    public static List<string> TeamA = new List<string>();
    public static List<string> TeamB = new List<string>();
}
