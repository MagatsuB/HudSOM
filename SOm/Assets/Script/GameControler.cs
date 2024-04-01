using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public List<AudioSource> _audioHUD, _audioMusic, _audioGame;
    public bool _muteHUD, _muteMusic, _muteGame;
    void Start()
    {
        
    }
    
    void Update()
    {
        for(int i = 0; i < _audioHUD.Count; i++)
        {
            _audioHUD[i].mute = _muteHUD;
        }
        for (int i = 0; i < _audioMusic.Count; i++)
        {
            _audioHUD[i].mute = _muteMusic;
        }
        for (int i = 0; i < _audioGame.Count; i++)
        {
            _audioHUD[i].mute = _muteGame;
        }
    }
}
