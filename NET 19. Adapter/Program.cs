
List<IAudiofile> musicPlayer = new List<IAudiofile>();
musicPlayer.Add(new Mp3());
musicPlayer.Add(new FLAC());
musicPlayer.Add(new Maw());
musicPlayer.Add(new OggAudioFileAdapter());
MyString myString = new MyString("Salam");
Console.WriteLine(myString);

musicPlayer.ForEach(m=>m.Play());
interface IAudiofile
{
    void Play();
}



class Mp3 : IAudiofile
{
    public void Play()
    {
        Console.WriteLine("Play Mp3");
    }
}

class Maw : IAudiofile
{
    public void Play()
    {
        Console.WriteLine("Play Mav");
    }
}


class FLAC : IAudiofile
{
    public void Play()
    {
        Console.WriteLine("Play FLAC");
    }
}

// Object Adapter

//class OggAudioFileAdapter : IAudiofile
//{
//    private Ogg m_ogg = new();

//    public void Play()
//    {
//        m_ogg.PlaySomething(true);
//    }
//}

class OggAudioFileAdapter : Ogg, IAudiofile
{
    
    public void Play()
    {
        this.PlaySomething(true);
    }
}

class MyString
{
    private string _str;

    public MyString(string str)
    {
        _str = str;
    }

    public string ToUpper()
    {
        return _str.ToUpper();
    }
    public string ToLower()
    {
        return _str.ToLower();
    }
    public string MyFunctionality()
    {
        var tmp = new string("");
        for (int i = 0; i < _str.Length; i++)
        {
            if (i % 2 == 0) tmp += _str[i].ToString().ToUpper();
            else tmp += _str[i].ToString().ToLower();
        }
        return tmp;
    }
}