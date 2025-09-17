using TMPro;
using UnityEngine;
public class HannoiManager : MonoBehaviour
{
    
    private MyStack<GameObject> pilar1 = new MyStack<GameObject>();
    private MyStack<GameObject> pilar2 = new MyStack<GameObject>();
    private MyStack<GameObject> pilar3 = new MyStack<GameObject>();
    [SerializeField] private GameObject discHolder;

    [SerializeField] private Vector2 pilar1Pos;
    [SerializeField] private Vector2 pilar2Pos;
    [SerializeField] private Vector2 pilar3Pos;

    private Vector3 mouseWorldPosition;
    [SerializeField] private Camera Camera;

    [Header("Discs")]
    [SerializeField] private GameObject disc1;
    [SerializeField] private GameObject disc2;
    [SerializeField] private GameObject disc3;
    [SerializeField] private GameObject disc4;
    [SerializeField] private GameObject disc5;

    [SerializeField] private GameObject[] discArray = new GameObject[5];

    private int moveCount = 0;

    [SerializeField] private TextMeshProUGUI textCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        discArray[0] = disc1;
        discArray[1] = disc2;
        discArray[2] = disc3;
        discArray[3] = disc4;
        discArray[4] = disc5;

        ResetStack();
    }

    // Update is called once per frame
    void Update()
    {
        if (discHolder != null)
        {
            mouseWorldPosition = Camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.nearClipPlane + 1));
            discHolder.transform.position = mouseWorldPosition;
        }

        textCount.text = "Moves: " + moveCount;
    }

    public void Pilar1()
    {
        if (discHolder == null)
        {
            TakeDisc(pilar1);
        }
        else 
        {
            if (pilar1.Count <= 0 || discHolder.GetComponent<IntHolder>().Value < pilar1.Peek().GetComponent<IntHolder>().Value) 
            {
                PlaceDisc(pilar1, discHolder, pilar1Pos);
            }
        }
    }
    public void Pilar2()
    {
        if (discHolder == null)
        {
            TakeDisc(pilar2);
        }
        else
        {
            if (pilar2.Count <= 0 || discHolder.GetComponent<IntHolder>().Value < pilar2.Peek().GetComponent<IntHolder>().Value)
            {
                PlaceDisc(pilar2, discHolder, pilar2Pos);
            }
        }
    }
    public void Pilar3()
    {
        if (discHolder == null)
        {
            TakeDisc(pilar3);
        }
        else
        {
            if (pilar3.Count <= 0 || discHolder.GetComponent<IntHolder>().Value < pilar3.Peek().GetComponent<IntHolder>().Value)
            {
                PlaceDisc(pilar3, discHolder, pilar3Pos);
            }
        }
    }
    public void TakeDisc(MyStack<GameObject> stack)
    {
        discHolder = stack.Pop();
    }
    public void PlaceDisc(MyStack<GameObject> stack, GameObject disc, Vector2 pilarPos)
    {
        discHolder = null;
        disc.transform.position = new Vector3(pilarPos.x, pilarPos.y + stack.Count * 0.5f, 0);
        stack.Push(disc);
        moveCount++;
    }

    public void ResetStack()
    {
        pilar2.Clear();
        pilar3.Clear();
        pilar1.Clear();

        for (int i = discArray.Length-1; i > -1; i--)
        {
            PlaceDisc(pilar1, discArray[i], pilar1Pos);
        }
        moveCount = 0;
    }
}
