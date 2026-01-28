using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện để chuyển cảnh
using UnityEngine.Video;

public class IntroController : MonoBehaviour
{
    public VideoPlayer introVideo;
    public string sceneToLoad = "SampleScene"; 

    void Start()
    {
        // Tự động bắt sự kiện khi video chạy hết
        introVideo.loopPointReached += OnVideoEnd;
    }

    // Hàm này chạy khi video kết thúc
    void OnVideoEnd(VideoPlayer vp)
    {
        LoadGame();
    }

    // Hàm này chạy khi bấm nút Skip
    public void OnSkipPressed()
    {
        LoadGame();
    }

    void LoadGame()
    {
        Debug.Log("Đang vào game...");
        SceneManager.LoadScene(sceneToLoad);
    }
}