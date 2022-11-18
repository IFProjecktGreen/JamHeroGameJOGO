using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtFinais : MonoBehaviour
{
    public void btFinais()
    {
        SceneManager.LoadScene("Menu Finais");
    }

    public void btInicio()
    {
        SceneManager.LoadScene("scene0");
    }
}
