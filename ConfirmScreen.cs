using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ConfirmScreen : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener, IUnityAdsListener

{

    public battleplayer player;
    public BattleScreen battleModeVisibility;
    public battlefinal final;
    public DistanceToCheckpoint distance;
    public PlayerController controllerP;
    public Levels forLevel;
    public GenController gens;
    public MermaidController mermaids;

    // проверь отдельные такие функции у русалок
    public AudioSource yessound;
    public AudioSource nosound;
    public AudioSource prizsound;
    public AudioSource prizsound2;

    public GameObject confirmBack;
    public GameObject noteBack;
    public GameObject presentBack;
    public Text noteText;
    public Text presentText;
    public Text presentText2;
    public Text presentText3;
    public Text confirmText;
    public GameObject confirmYes;
    public GameObject presentYes;
    public GameObject confirmNo;
    public GameObject confirmOk;
    public bool podtverjdenoTapom = false;
    public bool nepodtverjdenoTapom = false;
    public bool podtverjdenoOk = false;
    // Спец. экраны для гарема
    public GameObject confirmGaremBack;
    public Text confirmGaremText;
    public GameObject confirmGaremYes;
    public GameObject confirmGaremNo;
    public GameObject presentsreenback;
    public GameObject presentsreenback2;

    public string _adUnitId;
    [SerializeField] bool _testMode = false;
    [SerializeField] string _androidGameId;
    [SerializeField] string _iOSGameId;
    [SerializeField] string _gameId;

    public bool reklamagotova;

    void Awake()
    {
        Advertisement.AddListener(this);
        InitializeAds();
       
    }

    void InitializeAds()
    {
        _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? _iOSGameId
            : _androidGameId;
        Advertisement.Initialize(_gameId, _testMode, this);
    }

    void Start()
    {
        
        confirmBack.SetActive(false);
        presentBack.SetActive(false);
        noteBack.SetActive(false);
        podtverjdenoTapom = false;
        nepodtverjdenoTapom = false;
        podtverjdenoOk = false;
        confirmOk.SetActive(false);
        confirmYes.SetActive(false);
        confirmNo.SetActive(false);
        presentYes.SetActive(false);

        LoadAd();

    }

    public void Reklama() // сама реклама
    {
        if (reklamagotova)
        {

            Advertisement.Show(_adUnitId, this);
        }
        else
        {
            ReklamaAfter();
           // Advertisement.Load(_adUnitId, this);
        }
    }
    public void LoadAd()
    {
        // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled in a different script).
        Debug.Log("Loading Ad: " + _adUnitId);
        Advertisement.Load(_adUnitId, this);
    }

    // If the ad successfully loads, add a listener to the button and enable it:
    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        Debug.Log("Ad Loaded: " + adUnitId);
        reklamagotova = true;
    }

    // Implement the Show Listener's OnUnityAdsShowComplete callback method to determine if the user gets a reward:
    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
    {
        if (adUnitId.Equals(_adUnitId) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
            Debug.Log("Unity Ads Rewarded Ad Completed");
            // Grant a reward.
            ReklamaAfter();
        }
    }

    // Implement Load and Show Listener error callbacks:
    public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit {adUnitId}: {error.ToString()} - {message}");
        // Use the error details to determine whether to try to load another ad.
    }

    public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
        // Use the error details to determine whether to try to load another ad.
    }

    public void OnUnityAdsShowStart(string adUnitId) { }
    public void OnUnityAdsShowClick(string adUnitId) { }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        //if (showResult == ShowResult.Finished)
        //{
            // Reward the user for watching the ad to completion.
        //}
    }

    public void OnUnityAdsReady(string placementId) { }
    public void OnUnityAdsDidError(string message) { }
    public void OnUnityAdsDidStart(string placementId) { }


    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }


    public void Update()
    {
        if (noteBack.activeSelf == true && podtverjdenoOk == true && final.moskcolorchange == false)
        {
            noteBack.SetActive(false);
            noteText.text = " ";
            confirmOk.SetActive(false);
        }
        else if (noteBack.activeSelf == true && podtverjdenoOk == true && final.moskcolorchange)
        {
            Reklama();
        }
        if (confirmBack.activeSelf == true)
        {
            confirmYes.SetActive(true);
        }
        else
        {
            confirmText.text = " ";
            confirmYes.SetActive(false);

        }
        if (noteBack.activeSelf == false)
        {
            noteText.text = " ";
            confirmOk.SetActive(false);

        }
        else
        {
            confirmOk.SetActive(true);
        }
        if (presentBack.activeSelf == false)
        {
            presentText.text = " ";
            presentText2.text = " ";
            presentText3.text = " ";
            presentYes.SetActive(false);
        }

    }
    public void PointerClick()
    {
        if (presentsreenback.activeSelf == false && presentsreenback2.activeSelf == false)
        {
            if ((distance.distance < 5050 && gens.gensBack.activeSelf == false) || distance.distance > 5050)
            {
                yessound.Play(0);
            }
        }
        podtverjdenoTapom = true;
    }
    public void PointerClickNo()
    {
        nosound.Play(0);
        nepodtverjdenoTapom = true;
        confirmBack.SetActive(false);
        forLevel.sbrosChance.SetActive(false);
        controllerP.difference = false;
        controllerP.anotherdifference = false;
        gens.SpritsEbosh = false;
    }
    public void PointerClickOk()
    {
        if (presentsreenback.activeSelf == false && presentsreenback2.activeSelf == false && !gens.shprits.isPlaying)
        {
            yessound.Play(0);
        }
        podtverjdenoOk = true;
        podtverjdenoTapom = false;
        nepodtverjdenoTapom = false;
    }

   
    public void ReklamaAfter() // награда
    {

        noteBack.SetActive(false);
        noteText.text = " ";
        confirmOk.SetActive(false);

        // тут пропуск
        battleModeVisibility.newMermaids = 0;
        mermaids.mermaidButtonImitator.SetActive(false);
        player.playingMode = false;
        final.resultMode = false;
        final.nagradataker = false;
        battleModeVisibility.skippingMode = true;
        final.moskcolorchange = false;
        final.mosk.color = final.normalmoskcolor;
        final.galochka.color = final.normalmoskcolor;
    }
}
