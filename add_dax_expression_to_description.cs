foreach (var m in Selected.Measures)
{
    int index = m.Description.IndexOf("Expression:");
    if (index >= 0)
    {
        m.Description = m.Description.Substring(0, index+11) + System.Environment.NewLine + m.Expression;
    }
    else
    {
        m.Description = m.Description + System.Environment.NewLine + System.Environment.NewLine + "Expression:" + System.Environment.NewLine + m.Expression;
    };
}; 