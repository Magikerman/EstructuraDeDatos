using UnityEngine;

public class PalindromeCheck : MonoBehaviour
{
    [SerializeField] string strinAnalize;


    public bool palincheck(string str, int pos)
    {
        char[] charArray = str.ToCharArray();
        if (pos < charArray.Length/2)
        {
            if (charArray[pos] == charArray[charArray.Length - 1 - pos])
            {
                return palincheck(str, pos+1);
            }
            else { return false; }
        }
        else return (true);
    }
}
