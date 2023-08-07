[Serializable]
public class MyClass
{
    private int Age { get; set; }
    private string Occupation;
    private string Reply => $"{Age}-i-am";
    public string FirstName { get; private set; } = "Rowan";
    public string LastName { get; set; } = "Atkinson";
    public MyClass() { Occupation = "Actor"; }
    public void SetFamily(string occupation) { Occupation = occupation; }
}
