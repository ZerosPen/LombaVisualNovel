using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Characters;
using DIALOGUE;
using TMPro;

namespace TESTING
{
    public class Test_Char : MonoBehaviour
    {
        private Character CreatCharacter(string name) => CharacterManager.Instance.createChracter(name);

        public TMP_FontAsset tempFont;
        // Start is called before the first frame update
        void Start()
        {
            //Character Raelin = CharacterManager.Instance.createChracter("Raelin"); // Corrected spelling
            //Character Lila = CharacterManager.Instance.createChracter("Lila"); // Corrected spelling
            //Character Ran = CharacterManager.Instance.createChracter("Ran"); // Corrected spelling
            //Character Lilo = CharacterManager.Instance.createChracter("Lilo"); // Corrected spelling
            StartCoroutine(Test());
        }

        IEnumerator Test()
        {
            Character guard1 = CreatCharacter("Guard1 as Generic");
            Character guard2 = CreatCharacter("Guard2 as Generic");
            Character guard3 = CreatCharacter("Guard3 as Generic");

            guard1.Show();
            guard2.Show();
            guard3.Show();


            //guard1.SetDialogueFont(tempFont);
            //guard1.SetDialogueColor(Color.yellow);
            //guard2.SetDialogueColor(Color.gray);
            //guard3.SetDialogueColor(Color.blue);


            guard1.Say("Hello, why are you steal this money? {wc 1} what for this money?");
            guard1.Say("Let them talk First!");
            guard1.Say("GO {wc 1} SPEAK NOW!");


            yield return null;
        }

        // Update is called once per frame
        void Update()
        {
            // This method can be used for future updates
        }
    }
}