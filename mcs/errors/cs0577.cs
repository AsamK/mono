// cs0577.cs: Conditional not valid on 'MainClass.I.F()' because it is a destructor, operator, or explicit interface implementation// Line: 10

interface I
{
    void F ();
}

class MainClass: I {
        [System.Diagnostics.Conditional("DEBUG")]
        void I.F () {}
}
