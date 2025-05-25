Base @base = new();
Derived derived = new Derived();

//@base.Show();
//derived.Show();

// Reference to Base class
//Base obj = new Derived(); // upcast
//obj.Show();
//((Derived)obj).Show(); // downcast

Base[] arr = [@base, derived, new Child()];
foreach (var b in arr)
{
   // b.Show();
    (b as Derived)?.Print();    
}

//Foo(@base);
//Foo(derived);
//Foo(new Child());

void Foo(Base @base)
{
    //@base.Show();
    #region version1
    //if (@base.GetType() == new Derived().GetType())
    //{
    //    ((Derived)@base).Show();
    //}

    //else if (@base.GetType() == new Child().GetType())
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();   
    //}
    #endregion

    #region version 2
    //try
    //{
    //    ((Derived)@base).Show();
    //}
    //catch (Exception ex) { }
    //try
    //{
    //    ((Child)@base).Show();
    //}
    //catch (Exception ex) { }
    //try
    //{
    //    @base.Show();
    //}
    //catch (Exception ex) { }
    #endregion

    #region version 3
    //if(@base is Derived)
    //{
    //    ((Derived)@base).Show();
    //}
    //else if(@base is Child)
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}

    #endregion

    #region version 4
    //var value = @base is Derived ? (Derived)@base : null;
    //if (value != null) value.Show();

    //var value1 = @base as Derived; // as - yoxlamad yeni neyin ne oldugunu anlayir
    //var value2 = @base as Child; // as - yoxlamad yeni neyin ne oldugunu anlayir
    //var value3 = @base as Base; // as - yoxlamad yeni neyin ne oldugunu anlayir
    //if(value1 is not null) value1.Show();
    //else if(value2 is not null) value2.Show();
    //else if(value3 is not null) value3.Show();

    //(@base as Derived)?.Show(); // bu daha qisa yoludu

    #endregion

    @base.Show();

}

