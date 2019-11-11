using UnityEngine;
public class AddScore : MonoBehaviour
{
    public delegate void SendScore(int theScore);
    public static event SendScore OnSendScore;
    public int score = 10;
    public void Die()
    {
        if (OnSendScore != null)
        {
            OnSendScore(score);
        }
    }
}
