using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int trashCount = 0;
    public TMP_Text trashText;

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddTrash()
    {
        trashCount++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (trashText != null)
            trashText.text = trashCount.ToString();
    }
}