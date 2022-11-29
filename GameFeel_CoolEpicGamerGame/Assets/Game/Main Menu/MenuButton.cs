using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] MenuButtonController MenuButtonController;
    [SerializeField] Animator animator;
    [SerializeField] int thisIndex;
    [SerializeField] AnimationFunctions animationFunctions;
    public int menuObjectIndex;
    public GameObject menuObject;
    public GameObject menuObject2;

    bool keyDown = true;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (MenuButtonController.index == thisIndex)
        {
            animator.SetBool("Selected", true);
            if (Input.GetAxis("Submit") == 1)
            {
                if (!keyDown)
                {
                    keyDown = true;
                    animator.SetBool("Pressed", true);
                    if (thisIndex == 0)
                    {
                        if (menuObjectIndex == 0)
                        {
                            Invoke("StartGame", 1);
                            MenuButtonController.enabled = false;
                        } else if (menuObjectIndex == 1)
                        {
                            menuObject.SetActive(!menuObject.activeSelf);
                            menuObject2.SetActive(!menuObject2.activeSelf);
                        }
                    } else if (thisIndex == 1)
                    {
                        if (menuObjectIndex == 0)
                        {
                            menuObject.SetActive(!menuObject.activeSelf);
                            menuObject2.SetActive(!menuObject2.activeSelf);
                        }
                    }
                }

            } else if (animator.GetBool("Pressed"))
            {
                keyDown = false;
                animator.SetBool ("Pressed", false);
                animationFunctions.disableOnce = true;
            }
            else
            {
                keyDown=false;
            }
        } else
        {
            animator.SetBool("Selected", false);
        }
    }

    void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void MenuSwitch()
    {

    }
}
