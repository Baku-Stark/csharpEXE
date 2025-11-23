using System.Collections;

namespace InterContent;

public class C002ArrayList
{
    public void ShowC002ArrayList()
    {
        var arlist = new ArrayList();
        arlist.Add("BMW");
        arlist.Add("Mercedes");
        
        arlist.Remove("BMW");

        foreach (var ar in arlist)
        {
            Console.WriteLine(ar);
        }
    }
}