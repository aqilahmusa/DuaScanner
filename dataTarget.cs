using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
    public class dataTarget : MonoBehaviour
    {

        public Transform TextTargetName;
        public Transform DuaTitle;
        public Transform TextDescription;
        public Transform TextDescription1;
        public Transform ButtonAction;
        public Transform PanelDescription;

        public AudioSource soundTarget;
        public AudioClip clipTarget;

        // Use this for initialization
        void Start()
        {
            //add Audio Source as new game object component
            soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                //Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

                TextTargetName.GetComponent<Text>().text = name;
                ButtonAction.gameObject.SetActive(true);
                DuaTitle.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                TextDescription1.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);

                if (name == "585628418")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track1"); });
                    DuaTitle.GetComponent<Text>().text = "Testing";
                    TextDescription.GetComponent<Text>().text = "أَشْهَدُ أَن لَّا إِلَهَ إِلَّا اللهُ\r\n وَأَشْهدُ أَنَّ مُحَمَّدًا رَسُولُ الله";
                    TextDescription1.GetComponent<Text>().text = "There is no god but Allah,\r\n and Muhammad is His messenger";
                }

                if (name == "SYAHADAH")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track1"); });
                    DuaTitle.GetComponent<Text>().text = "SYAHADAH";
                    TextDescription.GetComponent<Text>().text = "أَشْهَدُ أَن لَّا إِلَهَ إِلَّا اللهُ\r\n وَأَشْهدُ أَنَّ مُحَمَّدًا رَسُولُ الله";
                    TextDescription1.GetComponent<Text>().text = "There is no god but Allah,\r\n and Muhammad is His messenger";
                }


                if (name == "DU'A FOR PARENTS")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track2"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A FOR PARENTS";
                    TextDescription.GetComponent<Text>().text = "رَبِّ اغْفِرْلِي وَلِوَالِدَيَّ وَارْحَمْحُمَا\r\n كَمَا رَبَّيَانِي صَغِيرًا";
                    TextDescription1.GetComponent<Text>().text = "Oh my Lord! Forgive me and my parents \r\n Oh my Lord! Have mercy on both of them \r\n as they cared for me when I was little";
                }

                if (name == "DU'A FOR ENLIGHTENING THE HEART")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track3"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A FOR ENLIGHTENING THE HEART";
                    TextDescription.GetComponent<Text>().text = "اللَّهُمَّ إِنِّ أَسْأَلُكَ عِلْمًا نَافِعًا\r\n وَرِزْقًا طَيِّبًا وَعَمَلاً مُتَقَبَّلاً";
                    TextDescription1.GetComponent<Text>().text = "Oh Allah! I ask You for useful knowledge, goodly provision and acceptable deeds";
                }

                if (name == "DU'A FOR WEARING GARMENTS")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track4"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A FOR WEARING GARMENTS";
                    TextDescription.GetComponent<Text>().text = "اَلْحَمْدُلِلَّهِ الَّذِي كَسَانِي هَذَا (الثَّوبَ) \r\nوَرَزَقَنِيهِ مِنْ غَيْرِ حَوْلٍ مِّنِّي وَلَا قُوَّة";
                    TextDescription1.GetComponent<Text>().text = "All praise if for Allah who has clothed me \r\n with this garment and provided it for me,\r\n with no power not might from myself";
                }

                if (name == "DU'A BEFORE ABLUTION")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track5"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A BEFORE ABLUTION";
                    TextDescription.GetComponent<Text>().text = "بِسْمِ اللهِ وَالْحَمْدُلِلَّه";
                    TextDescription1.GetComponent<Text>().text = "In the name of Allah \r\n and all praise is for Allah";
                }

                if (name == "DU'A AFTER ABLUTION")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track6"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A AFTER ABLUTION";
                    TextDescription.GetComponent<Text>().text = "أَشْهَدُ أَن لَّا إِلَهَ إِلَّا اللهُ وَحْدَهُ لَاشَرِيكَ لَهُ\r\n وَأَنَّ مُحَمَّدًا عَبْدُهُ وَرَسُولُهُ";
                    TextDescription1.GetComponent<Text>().text = "I bear witness that none has the right \r\n to be worshipped except Allah, alone \r\n without partner, and that Muhammad \r\n is His slave and messenger";
                }

                if (name == "DU'A BEFORE SLEEPING")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track7"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A BEFORE SLEEPING";
                    TextDescription.GetComponent<Text>().text = "اَللَّهُمَّ بِاسْمِكَ أَحْيَا وَأَمُوتُ";
                    TextDescription1.GetComponent<Text>().text = "In Your name Oh Allah, I live and I die";
                }

                if (name == "DU'A WAKING UP FROM SLEEP")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track8"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A WAKING UP FROM SLEEP";
                    TextDescription.GetComponent<Text>().text = "الْحَمْدُلِلَّهِ الَّذِي أَحْيَانَا بَعْدَمَا أَمَاتَنَا\r\n وَإِلَيْهِ النُّشُورُ";
                    TextDescription1.GetComponent<Text>().text = "All praises is for Allah who gave us life \r\n after having taken it from us \r\n and unto Him is the resurrection";
                }

                if (name == "DUA_ENTERING_THE_MOSQUE")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track9"); });
                    DuaTitle.GetComponent<Text>().text = "DUA ENTERING THE MOSQUE";
                    TextDescription.GetComponent<Text>().text = "اللَّهُمَّ افْتَحْلِي أَبْوَابَ رَحْمَتِكَ";
                    TextDescription1.GetComponent<Text>().text = "Oh Allah open the gates \r\n of Your mercy for me";
                }

                if (name == "DU'A LEAVING THE MOSQUE")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track10"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A LEAVING THE MOSQUE";
                    TextDescription.GetComponent<Text>().text = "اللَّهُمَّ إِنِّ أَسْأَلُكَ مِن فَضْلِكَ";
                    TextDescription1.GetComponent<Text>().text = "Oh Allah I ask You from Your favour";
                }

                if (name == "DU'A BEFORE EATING")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track11"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A BEFORE EATING";
                    TextDescription.GetComponent<Text>().text = "اللَّهُمَّ بَارِكْ لَنَا فِيمَا رَزَقْتَنَا\r\n وَقِنَا عَذَابَ النَّارِ";
                    TextDescription1.GetComponent<Text>().text = "Oh Allah! Bless(the food) You have \r\n provided us and save us from \r\n the punishment of the fire";
                }


                if (name == "DU'A AFTER EATING")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track12"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A AFTER EATING";
                    TextDescription.GetComponent<Text>().text = "الْحَمْدُلِلَّهِ الَّذِي أَطْعَمَنَا وَسَقَانَا\r\n وَجَعَلَنَا مِنَ الْمُسْلِمِين";
                    TextDescription1.GetComponent<Text>().text = "Praise be to Allah Who has fed us, \r\n and given us drink, \r\n and made us Muslims";
                }

                if (name == "DU'A LEAVING THE HOME")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track13"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A LEAVING THE HOME";
                    TextDescription.GetComponent<Text>().text = "بِسْمِ اللهِ تَوَكَّلْتُ عَلَى اللهِ \r\nلَاحَوْلَ وَلَا قُوَّتَ إِلَّا بِاللهِ";
                    TextDescription1.GetComponent<Text>().text = "In the name of Allah, I place my trust \r\n in Allah and there is no might nor power \r\n except with Allah";
                }

                if (name == "DU'A ENTERING THE HOME")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track14"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A ENTERING THE HOME";
                    TextDescription.GetComponent<Text>().text = " بِسْمِ اللَّهِ وَلَجْنَا وَبِسْمِ اللَّهِ خَرَجْنَا،\r\n وَعَلَى اللَّهِ رَبَّنَا تَوَكَّلْن";
                    TextDescription1.GetComponent<Text>().text = "In the name of Allah we enter \r\n and in the name of Allah we leave \r\n and upon our Lord we depend";
                }

                if (name == "DU'A BOARDING A VEHICLE")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track15"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A BOARDING A VEHICLE";
                    TextDescription.GetComponent<Text>().text = "سُبْحَانَ الَّذِي سَخَّرَلَنَا هَذَا وَمَا كُنَّا لَهُ\r\n مُقْرِنِينَ وَإِنَّ إِلى رَبِّنَا لَمُنْقَلِبُونَ";
                    TextDescription1.GetComponent<Text>().text = "Glory to Him Who has provided this \r\n for us though we could never \r\n have had it by our efforts. \r\n Surely unto our Lord we are returning.";
                }

                if (name == "DU'A ENTERING THE TOILET")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track16"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A ENTERING THE TOILET";
                    TextDescription.GetComponent<Text>().text = "اللَّهُمَّ إِنِّي أَعُوذُبِكَ \r\nمِنَ الْخُبْثِ وَالْخَبَائِث";
                    TextDescription1.GetComponent<Text>().text = "Oh Allah! I seek refuge with you \r\n from all evil and evil-doers";
                }

                if (name == "DU'A LEAVING THE TOILET")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/track17"); });
                    DuaTitle.GetComponent<Text>().text = "DU'A LEAVING THE TOILET";
                    TextDescription.GetComponent<Text>().text = "غُفْرَانَكَ الْحَمْدُ لِلَّهِ الَّذِي \r\nأَذْهَبَ عَنِّي الاَذَى وَعَفَانِى";
                    TextDescription1.GetComponent<Text>().text = "I seek forgiveness and pardon from You \r\n All praise be to Allah, who removed \r\n the difficulty from me and give me ease";
                }

            }
        }

        //function to play sound
        void playSound(string ss)
        {
            clipTarget = (AudioClip)Resources.Load(ss);
            soundTarget.clip = clipTarget;
            soundTarget.loop = false;
            soundTarget.playOnAwake = false;
            soundTarget.Play();
        }

    }
}
