using UnityEngine;

public class CreditsController : MonoBehaviour
{
  public int CreditHeight = 50;

  public float CreditSpeed = 20;

  private string[] _credits = new string[]
  {
    "Wobble Dog - Twilight: The Reckoning was inspired by Wobble Dog, by Anthony Blake",
    "Justin Ryder - Programmer",
    "Robert Drury - Programmer",
    "Brook Chipman - Kanye Target Art",
    "Anthony Blake - Wobble Dog IP Holder"
  };

  private float y = -99999;

  public void OnGUI()
  {
    if (GUI.Button(new Rect(10, 10, 100, 30), "Back to Menu"))
    {
      Application.LoadLevel("menu");
    }

    if (GUI.Button(new Rect((Screen.width / 2.0f) - 100, 10, 200, 30), "Play the original Wobble Dog!"))
    {
      Application.OpenURL("http://anthonyblake.org/content/Unity/WobbleDog/Player.html");
    }

    var centeredStyle = GUI.skin.GetStyle("Label");
    var alignment = centeredStyle.alignment;
    centeredStyle.alignment = TextAnchor.UpperCenter;
    for (var i = 0; i < _credits.Length; i++)
    {
      GUI.Label(new Rect(0, y + (i * CreditHeight), Screen.width, CreditHeight), _credits[i], centeredStyle);
    }

    centeredStyle.alignment = alignment;

    y -= CreditSpeed * Time.deltaTime;
    if (y < _credits.Length * -CreditHeight)
    {
      y = Screen.height;
    }
  }
}