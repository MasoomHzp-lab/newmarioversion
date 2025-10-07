using UnityEngine;

public class FallDetector : MonoBehaviour
{
    [Header("Settings")]
    public float fallLimitY = -5f; // وقتی Y پلیر از این مقدار پایین‌تر بره → Game Over

    private Transform player;
    private GameManageer gameManager;
    private bool hasDied = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        gameManager = FindObjectOfType<GameManageer>();
    }

    void Update()
    {
        if (player != null && !hasDied && player.position.y < fallLimitY)
        {
            hasDied = true;
            Debug.Log("💀 پلیر افتاد پایین!");
            gameManager.GameOver();
        }
    }
}
