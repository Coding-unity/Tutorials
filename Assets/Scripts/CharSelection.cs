using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CharSelection : MonoBehaviour
{
[Header("REFERENCES")]
public Sprite[] Character;
public Image RendererImage;
public GameObject LeftButton,RightButton;

public byte i;

private void Awake() => i=0;

private void Update()
{
if(i==0) 
{
LeftButton.SetActive(false);
RightButton.SetActive(true);
}

else if(i==2) 
{
    i=2;
    RightButton.SetActive(false);
    LeftButton.SetActive(true);   
}
else
{
RightButton.SetActive(true);
LeftButton.SetActive(true); 
}
}

public void LeftClick()
{
i--;
byte count = i;

RendererImage.sprite = Character[count];
}

public void RightClick()
{
++i;
byte count = i;

RendererImage.sprite = Character[count];
}

}