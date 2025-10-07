using UnityEngine;
using UnityEngine.SceneManagement;


public class GoalTrigger : MonoBehaviour
{
    
void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("🎉 برنده شدی!");
            // برای مثال، می‌تونی صحنه بعدی رو لود کنی
            // یا یه پیام نشون بدی:
            SceneManager.LoadScene("WinScene"); // اسم صحنه بردت رو بزن
        }
    }

}
