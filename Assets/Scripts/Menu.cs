using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{  
    public Slider volumeSlider;
    public AudioMixer mixer;

   public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Setting()
    {
        SceneManager.LoadScene(2);
    }

    public void Exist()
    {
        SceneManager.LoadScene(0);
    }

   public void Quit()
    {
        Application.Quit();
    }

    public void Thoatramenu()
    {
        SceneManager.LoadScene(0);
    }
   public void SetVolume()
    {
        mixer.SetFloat("volume", volumeSlider.value);
    }

   
}
