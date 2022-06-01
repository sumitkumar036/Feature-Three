using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
   public void YesIsClicked()
   {
       Application.Quit();
   }

   public void NoIsClicked(GameObject obj)
   {
       obj.SetActive(false);
   }
}
