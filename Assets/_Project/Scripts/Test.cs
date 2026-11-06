using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;


//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MyNamespace
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private Transform tr;
        [SerializeField] private Toggle toggle;
        [SerializeField] private TMP_InputField input;
        [SerializeField] private Slider slider;
        [SerializeField] private ScrollRect scrollbar;

        private Button button;

        private void OnEnable()
        {
            //button = GetComponent<Button>();
            //button.onClick.AddListener(OnButtonClicked);
            //button.onClick.AddListener(asd);
            toggle.onValueChanged.AddListener(OnToggleClicked);
            input.onValueChanged.AddListener(OnInputChanged);
            slider.onValueChanged.AddListener(OnSLiderChanged);
            scrollbar.onValueChanged.AddListener(Scrollbar);
        }

        private void OnDisable()
        {
            //button.onClick.RemoveListener(OnButtonClicked);
            //button.onClick.RemoveAllListeners();
            toggle.onValueChanged.RemoveAllListeners();
            input.onValueChanged.RemoveAllListeners();
        }

        private void FixedUpdate()
        {
            tr.eulerAngles += new Vector3(0, 10, 0) * Time.fixedDeltaTime;
        }

        private void OnButtonClicked()
        {
            Debug.Log("clicked!");

        }

        private void asd()
        {
            // event -> method()
            // event -> true,  method(bool p)
        }

        private void OnToggleClicked(bool isOn)
        {
            Mathf.Approximately(1.0f, 2.0f);
        }

        private void OnInputChanged(string input)
        {
            //Debug.Log(input);
            ParentClass.StatMethod();
        }


        private void OnSLiderChanged(float value)
        {

        }

        private void Scrollbar(Vector2 vect)
        {
            
        }
    }

    public class ParentClass
    {
        public GameObject Parent;

        public static void StatMethod()
        {
            Debug.Log("static");
        }
    }


    public class TestClass : ParentClass
    {
        private int _myNumber = 1;
        private float _myNumber1 = 12.4f;
        private bool _myBool = false;
        public string name = "asdasd";
        private char character = 'a';

        public int MyNumber { get { return _myNumber; } set { _myNumber = value; } }

        public int Num => _myNumber;


        public void ChangeNumber(int newNum)
        {
            
        }

        public int AddWithCondition(int a, int b)
        {
            int c = a + b;

            if (c > 10)
            {
                c += 100;
                return c;
            }
            else
            {
                return 0;
            }
        }

        public void Loops()
        {
            int asd = 100;

            //for (int i = 0; i < 10; i++)
            //{
            //    asd -= 10;

            //}

            do
            {
                asd -= 10;
            }
            while (asd > 0);



            while (asd > 0)
            {
                
            }

            Knight a = new();
            Knight d = new();

            List<Knight> knights = new();
            knights.Add(a);
            knights.Add(d);
            int index = knights.IndexOf(a);

            knights[index].name = "ddd";

            for (int i = 0; i < knights.Count; i++)
            {
                knights[i].name = "asd";
            }
        }


        public class Knight
        {
            public string name;

        }
    }
}