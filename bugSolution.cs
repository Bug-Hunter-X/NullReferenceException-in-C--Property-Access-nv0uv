public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        // Initialize MyProperty in the constructor
        MyProperty = 0; 
    }

    public void MyMethod() {
        // Now MyProperty will always have a value.
        int value = MyProperty * 2;
    }
}