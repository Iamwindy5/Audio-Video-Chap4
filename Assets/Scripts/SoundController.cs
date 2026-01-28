using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Biến để chứa cái AudioSource mình vừa tạo
    private AudioSource myAudio;

    void Start()
    {
        // Lấy component AudioSource đang gắn trên object này về để dùng
        myAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Nếu nhấn phím Space (Phím Cách)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Lệnh phát nhạc
            myAudio.Play();
            Debug.Log("Đang phát nhạc!"); // Dòng này để hiện thông báo check lỗi
        }

        // Nếu nhấn phím S
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Lệnh dừng nhạc
            myAudio.Stop();
            Debug.Log("Đã dừng nhạc!");
        }
    }
}