using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text nameText;
    public Text descriptionText;

    public Image artworkImage;

    public Text attackText;
    public Text healthText;
    public Text speedText;

    void Start()
    {
        card.Print();
        nameText.text = card.name;
        descriptionText.text = card.description;
        artworkImage.sprite = card.artwork;
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
        speedText.text = card.speed.ToString();

    }

    
}
