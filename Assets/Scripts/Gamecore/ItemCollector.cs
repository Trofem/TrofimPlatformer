using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ItemCollector : MonoBehaviour
{
    [SerializeField] public static int strawberries;
    public static int allstrawberries;
    public static int need;
    [SerializeField] private int need_least = 6;
    [SerializeField] public static string LevelName;
    public string PreLevelName;
    public static string SceneName = "";

    private float waitTime;
    private Rigidbody2D rb;
    public PlayerMovement script;
    public static SpriteRenderer sprite;

    [SerializeField] private Text Stext;
    public static Text StrawberriesText;
    [SerializeField] private Text LevelText;
    [SerializeField] private Text tipText;
    [SerializeField] private Text allStText;
    [SerializeField] private int[] S_Need;
    [SerializeField] private string[] TextTips;

    [SerializeField] private AudioSource collectSoundEffect;
    private void Awake()
    {
        SceneName = SceneManager.GetActiveScene().name;
    }
    void Start()
    {
        StrawberriesText = Stext;
        strawberries = 0;
        rb = GetComponent<Rigidbody2D>();
        need = need_least;
        if (LevelName != "")
        {
            LevelName = PreLevelName;
        }
        StrawberriesText.text = strawberries + "/" + need + "";
        LevelText.text = "Level: " + LevelName + ".";
        Tips(TextTips[strawberries]);
        allStText.text = "Strawberries collected for the game: 0";
    }
    private void Update()
    {
        int coun = allstrawberries;
        allStText.text = "Strawberries collected for the game:" + coun;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawberry"))
        {
            Destroy(collision.gameObject);
            Strawberries();
            Debug.Log("Straw collected");
        }
    }
    public void Strawberries()
    {
        collectSoundEffect.Play();
        strawberries += 1;
        Debug.Log("Straw " + strawberries);
        Tips(TextTips[strawberries]);
        AllStraw(1);
    }
    public static void AllStraw(int st)
    {
        allstrawberries = allstrawberries + st;
        Debug.Log("All strawberries = " + allstrawberries + ".");
        StrawberriesText.text = strawberries + "/" + need;

    }
    private void Tips(string tip)
    {
        if (tip != "")
        {
            tipText.text = "Tip: " + tip + ".";
        }
        else
        {
            tipText.text = "";
        }
    }
}