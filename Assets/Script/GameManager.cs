using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int playerHeart = 3;

    public TMPro.TextMeshProUGUI heartText;
    public TMPro.TextMeshProUGUI deadText;

    public float invincibleTime = 3.0f;
    public bool isInvincible = false;

    public Animator anim;

    public bool isDead = false;

    // Start is called before the first frame update
    void Awake()
    {

    }

    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHeart <= 0)
        {
            isDead = true;
        }
    }

    public void Damage()
    {
        if (!isInvincible)
        {
            StartCoroutine(InVinsibleCoroutine());
            playerHeart--;
            heartText.text = ": " + playerHeart;
            anim.SetTrigger("Dead");
        }
    }

    IEnumerator InVinsibleCoroutine()
    {
        isInvincible = true;

        yield return new WaitForSeconds(invincibleTime);

        isInvincible = false;
    }

    public void GameEnd()
    {
        deadText.gameObject.SetActive(true);
    }

    public bool Dead
    {
        get { return isDead; } set { isDead = value; }
    }


}
