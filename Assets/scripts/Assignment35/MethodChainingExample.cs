using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class MethodChainingExample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            UpdateGameObject updateGameObject = new UpdateGameObject(gameObject);
            updateGameObject.SetPosition(new Vector3(0, 1, 0))
            .SetRotation(new Vector3(45, 0, 0))
            .SetScale(new Vector3(2, 2, 2));

        }

    }
    class UpdateGameObject
    {
        private GameObject gameObject;
        public UpdateGameObject(GameObject gameObject) => this.gameObject = gameObject;
        public UpdateGameObject SetPosition(Vector3 position)
        {
            gameObject.transform.position = position;
            return this;
        }
        public UpdateGameObject SetRotation(Vector3 rotation)
        {
            gameObject.transform.rotation = Quaternion.Euler(rotation);
            return this;
        }
        public UpdateGameObject SetScale(Vector3 scale)
        {
            gameObject.transform.localScale = scale;
            return this;
        }
    }


}
