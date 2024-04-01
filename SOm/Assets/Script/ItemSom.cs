using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSom : MonoBehaviour
{
    public bool _somHUD, _somMusic, _somGame;
    public GameControler _gameControler;
    public AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
       _gameControler = Camera.main.GetComponent<GameControler>();
       _audioSource = GetComponent<AudioSource>();
        if (_somHUD)
        {
            _gameControler._audioHUD.Add(_audioSource);
        }
        else if(_somMusic)
        {
            //_gameControler._audioHUD.Add(_audioSource);
        }
        else if(_somGame)
        {
            //_gameControler._audioHUD.Add(_audioSource);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
