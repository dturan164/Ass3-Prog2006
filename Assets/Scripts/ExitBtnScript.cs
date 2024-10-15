using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using Debug = UnityEngine.Debug;
using static System.Net.Mime.MediaTypeNames;

public class ExitBtnScript : MonoBehaviour
{
    public void ExitButton()
    {
        //quits application
        UnityEngine.Application.Quit();
        Debug.Log("Quit");               
    }
}
