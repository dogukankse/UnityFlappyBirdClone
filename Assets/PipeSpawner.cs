using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
   [SerializeField] private GameObject _pipePrefab;
   [SerializeField] private int _pipeCount;

   private Queue<PipeController> _pipes;

   private void Start()
   {
      _pipes = new Queue<PipeController>();

      for (int i = 0; i < _pipeCount; i++)
      {
         PipeController pipe = Instantiate(_pipePrefab, transform.position, Quaternion.identity).GetComponent<PipeController>();
         pipe.gameObject.SetActive(false);
         _pipes.Enqueue(pipe);
      }
      
      InvokeRepeating(nameof(Spawn),0.5f,1.5f);
   }

   private void Spawn()
   {
      PipeController pipe = _pipes.Dequeue();
      pipe.transform.position = transform.position;
      pipe.gameObject.SetActive(true);
      pipe.Init();
      _pipes.Enqueue(pipe);
   }
}
