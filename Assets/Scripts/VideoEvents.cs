using UnityEngine;
using UnityEngine.Video; 
using UnityEngine.SceneManagement; 

public class VideoEvents : MonoBehaviour
{
    private VideoPlayer myVideoPlayer;

    void Start()
    {
        // Tự tìm component VideoPlayer gắn cùng object này
        myVideoPlayer = GetComponent<VideoPlayer>();

        // ĐĂNG KÝ SỰ KIỆN: Khi video chạy hết -> Gọi hàm OnVideoEnd
        myVideoPlayer.loopPointReached += OnVideoEnd;
    }

    // Hàm này sẽ tự động chạy khi video kết thúc
    void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("Video đã kết thúc! Chuẩn bị chuyển cảnh...");
        // Ở bài Mini Project mình sẽ viết lệnh chuyển cảnh vào đây
    }
}