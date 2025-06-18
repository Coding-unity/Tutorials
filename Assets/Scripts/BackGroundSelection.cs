using UnityEngine;
using UnityEngine.UI;

public class BackGroundSelection : MonoBehaviour
{
[Header("REFERENCES")]
public Canvas BGCanvas;
public Canvas StartCanvas;
public GameObject Day,Night;

private void Awake()
{
    StartCanvas.enabled = true;
    BGCanvas.enabled = false;
    Day.SetActive(true);
}

public void Select()
{
    StartCanvas.enabled = false;
    BGCanvas.enabled = true;
}

public void DaySelection()
{
Day.SetActive(true);
Night.SetActive(false);

BGCanvas.enabled = false;
}

public void NightSelection()
{
Night.SetActive(true);
Day.SetActive(false);

BGCanvas.enabled = false;
}
}
