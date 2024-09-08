class TrafficLight()
{
    private string color;

    private void ChangeColor(string newColor)
    {
        if (color != newColor)
            color = newColor;
    }

    public string GetColor()
    {
        return color;
    }
}
