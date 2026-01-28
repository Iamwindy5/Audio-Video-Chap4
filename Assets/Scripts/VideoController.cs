using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer myVideoPlayer;

    void Update()
    {
        // Bắt sự kiện nhấn phím V
        if (Input.GetKeyDown(KeyCode.V))
        {
            // Nếu video chưa chạy thì cho chạy
            if (!myVideoPlayer.isPlaying)
            {
                myVideoPlayer.Play();
                Debug.Log("Đang phát Video!");
            }
            // (Mở rộng) Nếu muốn bấm V lần nữa để Pause thì thêm else vào đây
        }
    }
}