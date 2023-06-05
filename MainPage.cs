namespace MZ_Examen;
public partial class MainPage : ContentPage
{
    public class MainPage 
    {
    
        string translatedNumber;

    private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = MZ_Text.Text;
            translatedNumber = Core.MZ_Translator.ToNumber(enteredNumber);

            if (!string.IsNullOrEmpty(translatedNumber))
            {
                // TODO:
            }
            else
            {
                // TODO:
            }
        }
    
    }
}