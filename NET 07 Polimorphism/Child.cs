
//@base.Show();
//derived.Show();

// Reference to Base class

class Child : Base
{
    //public override void Show()
    //{
    //    Console.WriteLine("Child class Show()");
    //}
    public override void Show() // sadece override yazan base class daki yazdigin Show() methode gorsenecek!!
    {
        base.Show();
    }

}

