namespace MZ_Examen;
public partial class MainPage : ContentPage
{
    int count = 0;


    // Named Label - declared as a member of the class
    Label counterLabel;

    string translatedNumber;

    

    private void OnTranslate(object sender, EventArgs e)
    {
        string enteredNumber = MZ_Text.Text;
        translatedNumber = Core.MZ_Translator.ToNumber(enteredNumber);

        if (!string.IsNullOrEmpty(translatedNumber))
        {
            CallButton.IsEnabled = true;
            CallButton.Text = "Call " + translatedNumber;
        }
        else
        {
            CallButton.IsEnabled = false;
            CallButton.Text = "Call";
        }
    }
}