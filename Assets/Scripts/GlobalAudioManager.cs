using UnityEngine;

public class GlobalAudioManager : MonoBehaviour
{
    // Biến để nhớ trạng thái hiện tại (đang tắt hay mở)
    private bool isMuted = false;
    private bool isPaused = false;

    void Update()
    {
        // --- CHỨC NĂNG 1: MUTE (Phím M) ---
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted; // Đảo ngược trạng thái (Đang mở thành tắt, đang tắt thành mở)

            if (isMuted)
            {
                AudioListener.volume = 0; // Vặn volume tổng về 0
                Debug.Log("Đã Mute toàn bộ âm thanh");
            }
            else
            {
                AudioListener.volume = 1; // Vặn volume tổng lên max (100%)
                Debug.Log("Đã Unmute - Âm thanh trở lại");
            }
        }

        // --- CHỨC NĂNG 2: PAUSE (Phím P) ---
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;

            // Lệnh này cực mạnh: Dừng mọi tính toán âm thanh của Unity
            AudioListener.pause = isPaused;

            Debug.Log("Audio Pause: " + isPaused);
        }
    }
}