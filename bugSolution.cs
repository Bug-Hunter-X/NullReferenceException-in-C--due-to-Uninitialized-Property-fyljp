public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property

    public ExampleClass() { MyProperty = 0; } // Or initialize in the constructor

    public void MyMethod()
    {
        // Accessing a property that has been initialized.
        int value = MyProperty * 2; 
    }
}