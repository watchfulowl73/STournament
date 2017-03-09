using System;
using System.IO;
using System.Net;
using System.Globalization;
public class Player : IComparable<Player>
{
    private String Name;
    private String Surname;
    private int rating;
    public int coeff_1;
    public int coeff_2;
    public int coeff_3;
    public int coeff_4;

    //два конструктора. отличаются способом получения рейтинга
    public Player(string n, string s, int r)
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        Name = ti.ToTitleCase(n.ToLower());
        Surname = ti.ToTitleCase(s.ToLower());
        rating = r;
        coeff_1 = 0;
        coeff_2 = 0;
        coeff_3 = 0;
        coeff_4 = 0;
    }

    public Player(string n, string s)
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        Name = ti.ToTitleCase(n.ToLower());
        Surname = ti.ToTitleCase(s.ToLower());
        rating = get_rating();
        coeff_1 = 0;
        coeff_2 = 0;
        coeff_3 = 0;
        coeff_4 = 0;
    }

    //переопределенные ToString и 
    public override string ToString()
    {
        return String.Format("{0,-14} {1,-10}", Surname, Name);
    }

    public int CompareTo(Player obj)
    {
        if (this.coeff_1 > obj.coeff_1) return -1;
        if (this.coeff_1 < obj.coeff_1) return 1;
        if (this.coeff_2 > obj.coeff_2) return -1;
        if (this.coeff_2 < obj.coeff_2) return 1;
        if (this.coeff_3 > obj.coeff_3) return -1;
        if (this.coeff_3 < obj.coeff_3) return 1;
        if (this.coeff_4 > obj.coeff_4) return -1;
        if (this.coeff_4 < obj.coeff_4) return 1;
        if (this.rating > obj.rating)   return -1;
        if (this.rating < obj.rating)   return 1;
        else return 0;
    }

    //метод получающий рейтинг с fesa

    /*
     * need to search "Dan" and "Kyu" if difference is small
     * take  bigger and count from him
     */
    private int get_rating()
    {
        string urlStr = "http://www.shogi.net/fesa/index.php?mid=5&player=" + this.Name + "+" + this.Surname;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlStr);
        request.UserAgent = "Mozilla/4.0 (compatible; MSIE 5.01; Windows NT 5.0)";
        WebResponse response = request.GetResponse();
        Stream data = response.GetResponseStream();
        StreamReader reader = new StreamReader(data);
        string s = reader.ReadToEnd();
        data.Close();
        reader.Close();
        response.Close();



        int beg = s.IndexOf("Kyu") + 17;
        int followers = Int32.Parse(s.Substring(beg, s.IndexOf(",", beg) - beg));
        beg = s.IndexOf("views_count") + 13;
        int views = Int32.Parse(s.Substring(beg, s.IndexOf(",", beg) - beg));
        Console.WriteLine("{0,-18} {1,6} {2,8}", "ass", followers, views);

        return 1;
    }
}
