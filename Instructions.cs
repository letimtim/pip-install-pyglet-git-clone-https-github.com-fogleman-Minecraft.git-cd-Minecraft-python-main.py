using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Instructions : MonoBehaviour
{
    [SerializeField]
    public Button newgame;
    [SerializeField]
    public Button instructions;
    [SerializeField]
    public Button quit;
    [SerializeField]
    public Text show;
    // Start is called before the first frame update
  public void whenClicked()
   {
        newgame.gameObject.SetActive(false);
        instructions.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
        show.gameObject.SetActive(true);
    }
    public void cancel()
    {
        newgame.gameObject.SetActive(true);
        instructions.gameObject.SetActive(true);
        quit.gameObject.SetActive(true);
        show.gameObject.SetActive(false);
    }
}
