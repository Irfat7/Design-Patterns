//mp3 player interface
interface MediaPlayer
{
    void Play(string fileType, string filename);
}

//audioplayer can play mp3 directly
class AudioPlayer : MediaPlayer
{
    public void Play(string fileType, string filename)
    {
        if(fileType == null)
        {
            Console.WriteLine("Null reference exception");
            return;
        }
        if(fileType == "mp3") 
        {
            Console.WriteLine("Playing mp3");
        }
        //for any other advanced player we will used adapter class
        else if(fileType == "vlc" || fileType == "mp4")
        {
            MediaAdapter mediaAdapter = new MediaAdapter();
            mediaAdapter.Play(fileType, filename);
        }

    }
}

//Adapter class This class creates object of the
//advanced media player interface to play adavanced file
class MediaAdapter : MediaPlayer
{
    public void Play(string fileType, string filename)
    {
        if(fileType == null)
        {
            Console.WriteLine("Null reference exception");
            return;
        }

        if(fileType == "vlc")
        {
            AdvancedMediaPlayer advancedMediaPlayer = new VLCPlayer();
            advancedMediaPlayer.PlayVLC(fileType, filename);
        }
        else if(fileType == "mp4")
        {
            AdvancedMediaPlayer advancedMediaPlayer = new MP4Player();
            advancedMediaPlayer.PlayMP4(fileType, filename);
        }
    }
}

interface AdvancedMediaPlayer
{
    void PlayVLC(string fileType, string filename);
    void PlayMP4(string fileType, string filename);
}

class VLCPlayer : AdvancedMediaPlayer
{
    public void PlayMP4(string fileType, string filename)
    {
        //nothing
    }

    public void PlayVLC(string fileType, string filename)
    {
        if (fileType == null)
        {
            Console.WriteLine("Null reference exception");
            return;
        }
        if (fileType == "vlc")
        {
            Console.WriteLine("Playing vlc");
        }
        else
        {
            Console.WriteLine("Can not play this type of file");
        }
    }
}

class MP4Player : AdvancedMediaPlayer
{
    public void PlayMP4(string fileType, string filename)
    {
        if (fileType == null)
        {
            Console.WriteLine("Null reference exception");
            return;
        }
        if (fileType == "mp4")
        {
            Console.WriteLine("Playing mp4");
        }
        else
        {
            Console.WriteLine("Can not play this type of file");
        }
    }

    public void PlayVLC(string fileType, string filename)
    {
        //nothing
    }
}

class AdapterClient
{
    MediaPlayer MediaPlayer = new AudioPlayer();
    public AdapterClient(string fileType)
    {
        MediaPlayer.Play(fileType, "bla-bla");
    }
}

class AdapterProgramme
{
    //public static void Main(string[] args)
    //{
    //    AdapterClient mp3Client = new AdapterClient("mp3");
    //    AdapterClient mp4Client = new AdapterClient("mp4");
    //    AdapterClient vlcClient = new AdapterClient("vlc");
    //}
}