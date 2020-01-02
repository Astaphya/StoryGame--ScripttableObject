using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu( menuName = "State", order = 0)]
public class State : ScriptableObject {
    
   [TextArea(14,10) ] [SerializeField]  string storyText; // Text area ile story Textimizin boyutunu belirliyoruz . Degiskenkleri min lines , max lines 
   [SerializeField] State[] nextStates ;

   public  string GetStateStory ()
   {
      return storyText;
   }

   public State[] GetNextStates()
   {
      return nextStates ;
   }
}


