interface IMobile
{
    IAndroid GetAndroidPhone();
    Iios GetIosPhone();
}

class Samsung : IMobile
{
    public IAndroid GetAndroidPhone()
    {
        return new SamsungGalaxy();
    }

    public Iios GetIosPhone()
    {
        return new SamsungGuru();
    }
}
interface IAndroid
{
    string GetModelDetails();
}

interface Iios
{
    string GetModelDetails();
}

class SamsungGalaxy : IAndroid
{
    public string GetModelDetails()
    {
        return "samsung galaxy grand prime";
    }
}

class SamsungGuru : Iios
{
    public string GetModelDetails()
    {
        return "samsung ram not available";
    }
}


class MobileClient
{
    IAndroid androidPhone;
    Iios iosPhone;
    public MobileClient(IMobile factory)
    {
        androidPhone=factory.GetAndroidPhone();
        iosPhone=factory.GetIosPhone();
    }
    public string GetAndroidPhoneDetails()
    {
        return androidPhone.GetModelDetails();
    }

    public string GetIosPhoneDetails()
    {
        return iosPhone.GetModelDetails();
    }
}

public class AbstractFactoryProgramme
{
    //public static void Main(string[] args)
    //{
    //    IMobile samsung = new Samsung();
    //    MobileClient samsungClient = new MobileClient(samsung);

    //    Console.WriteLine(samsungClient.GetAndroidPhoneDetails());
    //    Console.WriteLine(samsungClient.GetIosPhoneDetails());
    //}
}