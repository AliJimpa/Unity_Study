using RealMethod;
using UnityEngine;

namespace BasicTutorialMessage.Example
{
    /// <summary>
    /// This is a script that shows an example usage of the "TutorialMessage" component
    /// </summary>
    public class ExampleUse : MonoBehaviour
    {
        [Header("Dependency")]
        [SerializeField] private W_Tutorial MyTutorial;
        [SerializeField] private Transform cube1;
        [SerializeField] private Transform cube2;
        [SerializeField] private RectTransform pointToMe1;
        [SerializeField] private RectTransform pointToMe2;
        [Header("Resource")]
        public TutorialConfig Message;

        [Button]
        private void PointToCube1()
        {
            if (!MyTutorial.IsMessageShown(Message))
            {
                UI_SimpleTutorial message = MyTutorial.ShowMessage<UI_SimpleTutorial>(Message, this);
                message.SetPosition(cube1.position, true, TutorialPlacement.POINT_TO_TOP, 2);
                message.OnFinished += () => { PointToCube2(); };
            }
        }
        private void PointToCube2()
        {
            print("You");
            //var message = SpawnTutorialObject();

            //message.OnMessageClosed += (sender, args) => { PointToText1(); };
        }
        // private void PointToText1()
        // {
        //     var message = SpawnTutorialObject();

        //     message.OnMessageClosed += (sender, args) => { PointToText2(); };
        // }
        // private void PointToText2()
        // {
        // }


    }
}