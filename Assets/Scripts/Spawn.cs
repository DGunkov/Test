using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube_prefab;

    private float _fixed_time_to_spawn;
    private float _time_to_spawn;

    private float _distance_to_destroy;

    private float _move_spead;

    [SerializeField]
    private TMP_InputField _input_ms;
    [SerializeField]
    private TMP_InputField _input_distance;
    [SerializeField]
    private TMP_InputField _input_time;


    void Update()
    {
        if(_input_ms.text.Length > 0 && _input_distance.text.Length > 0 && _input_time.text.Length > 0)
        {
            if (_time_to_spawn > 0)
            {
                _time_to_spawn -= Time.deltaTime;
            }
            else
            {
                float.TryParse(_input_ms.text, out _move_spead);
                float.TryParse(_input_distance.text, out _distance_to_destroy);
                float.TryParse(_input_time.text, out _fixed_time_to_spawn);

                Cube script_cube = Instantiate(_cube_prefab, transform).GetComponent<Cube>();
                script_cube.Move_spead = _move_spead;
                script_cube.Target_position = new Vector3(_distance_to_destroy, 0, 0);
                _time_to_spawn = _fixed_time_to_spawn;
            }
        }
    }
}
